using Microsoft.AspNetCore.Mvc;
using Nomadwork.Model_View;
using Nomadwork.Model_View.Establishmment_List;
using System.Collections.Generic;
using System.Linq;

namespace Nomadwork.Controllers
{
    [Route("api/establishmment")]
    [ApiController]
    public class EstablishmmentController : ControllerBase
    {
        ResultListEstablishmmentNameLocationId _establishmment;


        // GET api/values
        [HttpPost]
        public ActionResult<Json> Post([FromBody]Geolocation geolocation)
        {
            if (geolocation.Latitude == 0 && geolocation.Longitude == 0)
            {
                return NotFound();
            }

            CreatedListEstablishmment();

            var list = _establishmment.Establishmments
                                      .Where(x => decimal.Round(x.Geolocation.Latitude, 3)
                                                                .Equals(decimal.Round(geolocation.Latitude, 3))
                                                                || decimal.Round(x.Geolocation.Longitude, 3)
                                                                        .Equals(decimal.Round(geolocation.Longitude, 3))).ToHashSet().Take(20);

            if (list.Count().Equals(0))
            {
                return NotFound(Json.Create(string.Format("{0} Estabelecimentos encontrados", list.Count()), null));
            }


            return Ok(Json.Create(string.Format("{0} Estabelecimentos encontrados", list.Count()), list));
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Json> Get(string id)
        {
            var listPhoto = new List<string>
            {
                "https://vemvoar.voeazul.com.br/wp-content/uploads/2018/08/veja-o-que-fazer-em-recife-a-veneza-brasileira.jpeg",
                "https://static2.oimenu.com.br/data/images/recife-pe.jpg?21052019",
                "https://i1.wp.com/www.vidadeturista.com/wp-content/uploads/2009/03/recife-pe-530x398.jpg?resize=530%2C398"
            };

            CreatedListEstablishmment();

            var select = _establishmment.Establishmments.FirstOrDefault(x => x.Id.Equals(id));

            var establishmment = EstablishmmentById.Create(select.Id, select.Name, "08:00", "20:00");
            establishmment.AddServices(ServiceOffered.Internet(Quality.Good));
            establishmment.AddServices(ServiceOffered.Energy(Quantity.Little));
            establishmment.AddServices(ServiceOffered.Noise(Quantity.Much));
            establishmment.AddPhoto(listPhoto);



            return Ok(Json.Create("Estabelecimento Selecionado", establishmment));
        }

        [HttpDelete("{id}")]
        public ActionResult<Json> Delete(string id)
        {
            if (_establishmment.Establishmments == null
            || _establishmment.Establishmments.Count().Equals(0))
            {
                return NoContent();
            }
            var elemment = _establishmment.Establishmments.Find(x => x.Id.Equals(id));

            if (elemment == null)
            {
                return NotFound(Json.Create("Não existem estabelecimentos encontrados", null));
            }

            _establishmment.Establishmments.Remove(elemment);

            return Ok(Json.Create(string.Format("Elemento de ID{0} e Nome {1}", elemment.Id, elemment.Name), _establishmment.Establishmments));

        }


        [Route("so_pra_ver_enum")]
        [HttpGet]
        public string Enums()
        {

            return @"

        public enum Quantity
        {
            None = 0,
            Has = 1,
            Little = 2,
            Much = 3,
        }

        public enum Quality
        {
            Bad = 0,
            Regular = 1,
            Good = 2,
            Great = 3

        }
        public enum Service
        {
            Internet = 1,
            Energy = 2,
            Noise = 3
        }";
        }

        private void CreatedListEstablishmment()
        {

            _establishmment = ResultListEstablishmmentNameLocationId.GetInstance();

            var list = new List<EstablishmmentNameLocationId>
{
               EstablishmmentNameLocationId.Create("1000","3marias Paulista",-7.938026M,-34.87789M),
EstablishmmentNameLocationId.Create("1001","À Emporter",-8.035784M,-34.92516M),
EstablishmmentNameLocationId.Create("1002","A Moenda",-7.884429M,-34.90423M),
EstablishmmentNameLocationId.Create("1003","A Vida é Bela Café",-8.050359M,-34.95858M),
EstablishmmentNameLocationId.Create("1004","Abreu",-7.909597M,-34.91386M),
EstablishmmentNameLocationId.Create("1005","Açaí Concept",-8.01506M,-34.97796M),
EstablishmmentNameLocationId.Create("1006","Açaí e lanchonete Da Tia Kall",-7.832208M,-34.90021M),
EstablishmmentNameLocationId.Create("1007","Aconchego da Leitura Livraria & Cafeteria",-8.132257M,-34.90063M),
EstablishmmentNameLocationId.Create("1008","Acqua Setúbal - Peixes Ornamentais",-8.137471M,-34.91272M),
EstablishmmentNameLocationId.Create("1009","AcquaZero",-8.015054M,-34.97795M),
EstablishmmentNameLocationId.Create("1010","Adaptação de veículo para deficientes físicos ABDF",-7.928199M,-34.89743M),
EstablishmmentNameLocationId.Create("1011","Adon Cafeteria",-8.041351M,-34.93845M),
EstablishmmentNameLocationId.Create("1012","Adonto nil",-8.024127M,-35.00064M),
EstablishmmentNameLocationId.Create("1013","Adupé Café e Arte",-8.016447M,-34.84832M),
EstablishmmentNameLocationId.Create("1014","Alameda do sol",-8.005593M,-34.84082M),
EstablishmmentNameLocationId.Create("1015","Albuquerque Pneus - Abreu e Lima",-7.912411M,-34.90089M),
EstablishmmentNameLocationId.Create("1016","Albuquerque Pneus - Goiana",-7.567303M,-35.00276M),
EstablishmmentNameLocationId.Create("1017","Aldeia Business Park",-7.95988M,-35.01199M),
EstablishmmentNameLocationId.Create("1018","Aldeia Shopping",-7.988918M,-34.97245M),
EstablishmmentNameLocationId.Create("1019","Almoço Caseiro & Café Da Manhã",-7.948746M,-34.85358M),
EstablishmmentNameLocationId.Create("1020","Aloha Café & Açaí",-8.132398M,-34.90084M),
EstablishmmentNameLocationId.Create("1021","Alto Pinares Paseo De Compras",-8.474026M,-34.99626M),
EstablishmmentNameLocationId.Create("1022","AMA - Cafeteria e Tabacaria",-8.048812M,-34.95451M),
EstablishmmentNameLocationId.Create("1023","Amai café",-8.049188M,-34.95609M),
EstablishmmentNameLocationId.Create("1024","Ambiannce Noivas",-7.94383M,-34.86295M),
EstablishmmentNameLocationId.Create("1025","Amitié Café e Delícias",-8.127103M,-34.90082M),
EstablishmmentNameLocationId.Create("1026","Ana Clara Almeiida",-7.914828M,-34.90767M),
EstablishmmentNameLocationId.Create("1027","Antigo Café",-8.063572M,-34.87398M),
EstablishmmentNameLocationId.Create("1028","Aroma Café Bistrô",-8.103164M,-34.88814M),
EstablishmmentNameLocationId.Create("1029","Artesanato Camaragibe",-8.015054M,-34.97795M),
EstablishmmentNameLocationId.Create("1030","Arthur Shopping Paulista",-7.931464M,-34.89334M),
EstablishmmentNameLocationId.Create("1031","Atacadão - Igarassu",-7.879015M,-34.9042M),
EstablishmmentNameLocationId.Create("1032","Atacadão - Recife",-7.879467M,-34.90471M),
EstablishmmentNameLocationId.Create("1033","Atacadão - Recife - Atacado",-7.881941M,-34.90169M),
EstablishmmentNameLocationId.Create("1034","Atacado dos Presentes",-8.043214M,-34.90848M),
EstablishmmentNameLocationId.Create("1035","ATELIÊ CAFÉ OLINDA",-8.018591M,-34.85209M),
EstablishmmentNameLocationId.Create("1036","Au Au Pet Shop",-7.915479M,-34.9076M),
EstablishmmentNameLocationId.Create("1037","Auditórios Recife",-8.048271M,-34.89354M),
EstablishmmentNameLocationId.Create("1038","Banco do Brasil",-8.16933M,-34.9193M),
EstablishmmentNameLocationId.Create("1039","Bar e Restaurante Casa de Farinha",-8.014157M,-35.04254M),
EstablishmmentNameLocationId.Create("1040","Barrio Café e Bar",-8.019438M,-34.85394M),
EstablishmmentNameLocationId.Create("1041","be.work escritórios compartilhados",-8.034803M,-34.91891M),
EstablishmmentNameLocationId.Create("1042","Beehive Coworking",-8.03024M,-34.92258M),
EstablishmmentNameLocationId.Create("1043","Beiju Gourmet Tapiocaria e Café",-8.120687M,-34.89707M),
EstablishmmentNameLocationId.Create("1044","Belisco's Café Bistrô",-7.996756M,-35.03883M),
EstablishmmentNameLocationId.Create("1045","Bella Doce Café",-7.93797M,-34.87791M),
EstablishmmentNameLocationId.Create("1046","Belynha Sex Shop",-7.92108M,-34.92765M),
EstablishmmentNameLocationId.Create("1047","Bem Casado Doceria e Cafeteria",-8.005432M,-34.87138M),
EstablishmmentNameLocationId.Create("1048","Bem Me Quer - Doceria e Cafeteria",-8.009336M,-34.86551M),
EstablishmmentNameLocationId.Create("1049","Big Lanches",-7.828657M,-34.90919M),
EstablishmmentNameLocationId.Create("1050","Bike Fit Café",-8.01316M,-34.85316M),
EstablishmmentNameLocationId.Create("1051","Blue Horizon site",-8.036935M,-35.02451M),
EstablishmmentNameLocationId.Create("1052","Boi & Brasa",-7.893645M,-34.90377M),
EstablishmmentNameLocationId.Create("1053","Boil Coffee Shop",-8.139731M,-34.90783M),
EstablishmmentNameLocationId.Create("1054","Boleria das Marias",-8.044424M,-34.90045M),
EstablishmmentNameLocationId.Create("1055","Boleria of Marias",-8.142879M,-34.90903M),
EstablishmmentNameLocationId.Create("1056","Bolos e Tentações Doceria",-7.948228M,-34.89653M),
EstablishmmentNameLocationId.Create("1057","Borsoi Café",-8.104526M,-34.8876M),
EstablishmmentNameLocationId.Create("1058","Boss",-8.015451M,-34.97878M),
EstablishmmentNameLocationId.Create("1059","Botteghe, Pina - Recife",-8.094522M,-34.88556M),
EstablishmmentNameLocationId.Create("1060","Boulevard Mall",-7.962324M,-35.00881M),
EstablishmmentNameLocationId.Create("1061","Box China",-7.906571M,-34.9025M),
EstablishmmentNameLocationId.Create("1062","Brennand Café",-8.053739M,-34.97415M),
EstablishmmentNameLocationId.Create("1063","Brigadeiro Café",-8.126335M,-34.89906M),
EstablishmmentNameLocationId.Create("1064","BrOffices Virtual Office - NASA Unit - Goiania",-16.6971M,-49.25566M),
EstablishmmentNameLocationId.Create("1065","Bruna Pizzaria",-7.918146M,-34.92503M),
EstablishmmentNameLocationId.Create("1066","Building Parking Shopping Boa Vista",-8.059547M,-34.88722M),
EstablishmmentNameLocationId.Create("1067","Bunker Coworking",-8.039195M,-34.91904M),
EstablishmmentNameLocationId.Create("1068","Burger Grill",-7.99455M,-35.04199M),
EstablishmmentNameLocationId.Create("1069","Cabidela do Pavão",-7.821255M,-34.91699M),
EstablishmmentNameLocationId.Create("1070","Café & Letras Bistrô",-8.047022M,-34.90115M),
EstablishmmentNameLocationId.Create("1071","Café 285-Fusion",-8.04395M,-34.89281M),
EstablishmmentNameLocationId.Create("1072","Café Anna Corina",-8.085634M,-34.89521M),
EstablishmmentNameLocationId.Create("1073","Café com Dengo",-8.036499M,-34.89936M),
EstablishmmentNameLocationId.Create("1074","Café da Praça",-8.009341M,-34.8425M),
EstablishmmentNameLocationId.Create("1075","Café do brejo Recife",-8.054573M,-34.87712M),
EstablishmmentNameLocationId.Create("1076","Café do Porto",-8.0162M,-34.97768M),
EstablishmmentNameLocationId.Create("1077","Cafe Gastro",-8.504819M,-35.00216M),
EstablishmmentNameLocationId.Create("1078","Café KM",-8.102391M,-34.88778M),
EstablishmmentNameLocationId.Create("1079","Café Liberal 1817",-8.063368M,-34.87314M),
EstablishmmentNameLocationId.Create("1080","Café mais Prosa",-8.043752M,-34.89312M),
EstablishmmentNameLocationId.Create("1081","Café Malungo",-8.041367M,-34.8918M),
EstablishmmentNameLocationId.Create("1082","Café Marita Recife Pernambuco",-8.126099M,-34.90325M),
EstablishmmentNameLocationId.Create("1083","Café Praliné",-8.029235M,-34.90714M),
EstablishmmentNameLocationId.Create("1084","Café São Braz",-8.063902M,-34.87152M),
EstablishmmentNameLocationId.Create("1085","Café Tão - Cafeteria",-8.037976M,-34.89872M),
EstablishmmentNameLocationId.Create("1086","Cafecafe Rosa e Silva",-8.036883M,-34.90136M),
EstablishmmentNameLocationId.Create("1087","Cafeteria",-8.040175M,-34.91038M),
EstablishmmentNameLocationId.Create("1088","Cafeteria Cafe & Cultura",-7.903203M,-34.88889M),
EstablishmmentNameLocationId.Create("1089","Cafeteria Maia",-8.031242M,-34.91466M),
EstablishmmentNameLocationId.Create("1090","Cafeteria Santa Clara",-8.048518M,-34.90128M),
EstablishmmentNameLocationId.Create("1091","Cafeteria Santa Clara Boa Viagem",-8.095984M,-34.88336M),
EstablishmmentNameLocationId.Create("1092","Cafeteria Santa Clara Parnamirim",-8.03345M,-34.90873M),
EstablishmmentNameLocationId.Create("1093","Cafeteria Santa Clara Setúbal",-8.141145M,-34.90603M),
EstablishmmentNameLocationId.Create("1094","Caixa Postal em Recife",-8.137835M,-34.9058M),
EstablishmmentNameLocationId.Create("1095","Calango Coworking Ltda",-8.053028M,-34.88814M),
EstablishmmentNameLocationId.Create("1096","Caldeirada da Irene",-7.773926M,-34.89131M),
EstablishmmentNameLocationId.Create("1097","Caldeirada da Lidiane",-7.773447M,-34.89119M),
EstablishmmentNameLocationId.Create("1098","Câmarà Gourmet Food Truck",-8.015656M,-34.97222M),
EstablishmmentNameLocationId.Create("1099","Câmara Municipal de São Lourenço da Mata - Casa Jair Pereira de Oliveira",-7.994316M,-35.04214M),
EstablishmmentNameLocationId.Create("1100","Camará Shopping",-8.016256M,-34.97716M),
EstablishmmentNameLocationId.Create("1101","Candy House",-8.132141M,-34.90172M),
EstablishmmentNameLocationId.Create("1102","Capas & Cia",-8.037207M,-34.91222M),
EstablishmmentNameLocationId.Create("1103","Capitania Coworking",-8.064241M,-34.87658M),
EstablishmmentNameLocationId.Create("1104","Carinho de Vó - Cafés e Mimos",-8.042353M,-34.94764M),
EstablishmmentNameLocationId.Create("1105","Carlos Germano Advogados Associados",-7.995433M,-35.04145M),
EstablishmmentNameLocationId.Create("1106","Carrefour",-8.040445M,-34.91034M),
EstablishmmentNameLocationId.Create("1107","Casa Colonial",-8.015604M,-34.84677M),
EstablishmmentNameLocationId.Create("1108","Casa CRIA",-8.045052M,-34.90681M),
EstablishmmentNameLocationId.Create("1109","Casas Bahia",-7.996902M,-35.03659M),
EstablishmmentNameLocationId.Create("1110","Castigliani Cafés Especiais",-8.032309M,-34.91328M),
EstablishmmentNameLocationId.Create("1111","Center Service",-8.038775M,-34.91281M),
EstablishmmentNameLocationId.Create("1112","Centervet Centro de Terapia Veterinaria",-8.00719M,-34.86979M),
EstablishmmentNameLocationId.Create("1113","Central da Beleza",-8.025485M,-34.91756M),
EstablishmmentNameLocationId.Create("1114","Central HuB Coworking",-8.137835M,-34.9058M),
EstablishmmentNameLocationId.Create("1115","Chaveiro Rosa e Silva",-8.037687M,-34.90113M),
EstablishmmentNameLocationId.Create("1116","Cheirin Bão Empório Mineiro",-7.994202M,-34.84079M),
EstablishmmentNameLocationId.Create("1117","Cheirin Bão Recife",-8.109073M,-34.89013M),
EstablishmmentNameLocationId.Create("1118","Churrascaria e Pizzaria Caminho da Ilha",-7.820293M,-34.91113M),
EstablishmmentNameLocationId.Create("1119","Chuva De Flor",-7.909636M,-34.90149M),
EstablishmmentNameLocationId.Create("1120","City Working Recife",-8.107007M,-34.9126M),
EstablishmmentNameLocationId.Create("1121","Clandestino Café",-8.041836M,-34.90436M),
EstablishmmentNameLocationId.Create("1122","ClubWork",-8.048729M,-34.91211M),
EstablishmmentNameLocationId.Create("1123","Coffe Shop São Braz",-8.085704M,-34.89541M),
EstablishmmentNameLocationId.Create("1124","Coffee Made the Grain",-8.119376M,-34.90453M),
EstablishmmentNameLocationId.Create("1125","COFFEE SHOP SAO BRAZ",-8.036872M,-34.9129M),
EstablishmmentNameLocationId.Create("1126","Coffee Shop São Braz Espinheiro",-8.043962M,-34.89506M),
EstablishmmentNameLocationId.Create("1127","Coffee Shop Sao Braz Paulista",-7.938363M,-34.87776M),
EstablishmmentNameLocationId.Create("1128","Coffeetown Shopping Recife",-8.1186M,-34.90581M),
EstablishmmentNameLocationId.Create("1129","Coin's Coffee",-8.506809M,-35.00085M),
EstablishmmentNameLocationId.Create("1130","Collab Hub Recife - Coworking",-8.043054M,-34.89511M),
EstablishmmentNameLocationId.Create("1131","Comedoria Doce Mel",-8.107499M,-35.01839M),
EstablishmmentNameLocationId.Create("1132","Comedoria Recife",-8.132392M,-34.90895M),
EstablishmmentNameLocationId.Create("1133","Comercial Agro-Center Ltda",-7.560719M,-34.99889M),
EstablishmmentNameLocationId.Create("1134","Condomínio do Edifício Supercenter Caxangá",-8.031754M,-34.95553M),
EstablishmmentNameLocationId.Create("1135","Conecte Coworking",-8.131372M,-34.90649M),
EstablishmmentNameLocationId.Create("1136","Confeitaria Moinho do Tâmega",-8.035447M,-34.92083M),
EstablishmmentNameLocationId.Create("1137","Connection Coworking",-8.053383M,-34.90066M),
EstablishmmentNameLocationId.Create("1138","Conviva - Espaço de Convivência Compartilhado",-7.963916M,-35.00728M),
EstablishmmentNameLocationId.Create("1139","Cordel Specialty Coffees",-8.032734M,-34.91314M),
EstablishmmentNameLocationId.Create("1140","Coworking em Recife",-8.043546M,-34.89062M),
EstablishmmentNameLocationId.Create("1141","Coworking Recife",-8.048147M,-34.89346M),
EstablishmmentNameLocationId.Create("1142","Cris Zedarque- Amo Natura",-8.016407M,-34.92779M),
EstablishmmentNameLocationId.Create("1143","Crock Coffee Shop",-7.902477M,-34.83892M),
EstablishmmentNameLocationId.Create("1144","Cx. Elet. 24 Horas",-8.037967M,-34.87187M),
EstablishmmentNameLocationId.Create("1145","D'AMORE Gelateria e Comedoria",-7.559929M,-34.99538M),
EstablishmmentNameLocationId.Create("1146","Dani Nails Designer",-7.569955M,-35.02333M),
EstablishmmentNameLocationId.Create("1147","Daniele terta Nails Designer",-7.555158M,-35.0103M),
EstablishmmentNameLocationId.Create("1148","Delicias da Roça",-7.809979M,-34.92136M),
EstablishmmentNameLocationId.Create("1149","Delta Cafe",-8.041888M,-34.89769M),
EstablishmmentNameLocationId.Create("1150","Delta espresso",-8.086466M,-34.89408M),
EstablishmmentNameLocationId.Create("1151","Deltaexpresso",-8.122516M,-34.89806M),
EstablishmmentNameLocationId.Create("1152","Deltaexpresso - Cais do Imperador Recife - PE",-8.065261M,-34.87605M),
EstablishmmentNameLocationId.Create("1153","Deltaexpresso - Franquias",-8.098561M,-34.91027M),
EstablishmmentNameLocationId.Create("1154","Deltaexpresso - Recife Antigo",-8.063602M,-34.8743M),
EstablishmmentNameLocationId.Create("1155","Deltaexpresso Shopping Patteo Olinda",-7.994425M,-34.84159M),
EstablishmmentNameLocationId.Create("1156","Derby Shopping",-8.0523M,-34.89883M),
EstablishmmentNameLocationId.Create("1157","Detran",-8.118945M,-34.90483M),
EstablishmmentNameLocationId.Create("1158","Diego games",-7.563869M,-35.0141M),
EstablishmmentNameLocationId.Create("1159","Doutor Scholl",-8.035558M,-34.90852M),
EstablishmmentNameLocationId.Create("1160","Dunamis Coffee",-8.06882M,-34.99434M),
EstablishmmentNameLocationId.Create("1161","D'Vino Caffè",-8.128268M,-34.90581M),
EstablishmmentNameLocationId.Create("1162","Ecowork",-8.096588M,-34.88337M),
EstablishmmentNameLocationId.Create("1163","Edifício Garagem - Shopping Plaza",-8.036491M,-34.91276M),
EstablishmmentNameLocationId.Create("1164","Eletro Shopping",-7.559423M,-34.99973M),
EstablishmmentNameLocationId.Create("1165","Eli Pizza e Lanches",-8.008589M,-35.01483M),
EstablishmmentNameLocationId.Create("1166","ELLA CAFÉ",-8.125395M,-34.90114M),
EstablishmmentNameLocationId.Create("1167","Emmanuelle",-8.015054M,-34.97795M),
EstablishmmentNameLocationId.Create("1168","Empório 48 Padaria, Café e Restaurante",-8.039669M,-34.89484M),
EstablishmmentNameLocationId.Create("1169","Empório Bem me Quer",-8.062391M,-34.88239M),
EstablishmmentNameLocationId.Create("1170","Empório do Tio Paulo II",-7.773881M,-34.8981M),
EstablishmmentNameLocationId.Create("1171","Empório Doce - Cafeteria e Tapiocaria",-8.004967M,-35.03911M),
EstablishmmentNameLocationId.Create("1172","Emporio Jaqueira",-8.034864M,-34.90178M),
EstablishmmentNameLocationId.Create("1173","Empresarial Casa Forte",-8.033789M,-34.92176M),
EstablishmmentNameLocationId.Create("1174","Empresarial Desembargador Pedro Martiniano Lins",-8.050591M,-34.89328M),
EstablishmmentNameLocationId.Create("1175","Ernest Café Bistrô",-8.045808M,-34.89501M),
EstablishmmentNameLocationId.Create("1176","ESC Coworking",-8.089393M,-34.88481M),
EstablishmmentNameLocationId.Create("1177","Escritório Compartilhado Recife",-8.132401M,-34.90204M),
EstablishmmentNameLocationId.Create("1178","Escritório de Empreendedores",-7.833053M,-34.90687M),
EstablishmmentNameLocationId.Create("1179","Escritório de Estudo",-8.110751M,-34.90427M),
EstablishmmentNameLocationId.Create("1180","Escritório de Estudo e Caixa Postal",-8.123167M,-34.90432M),
EstablishmmentNameLocationId.Create("1181","Escritórios Inteligentes",-8.046722M,-34.89789M),
EstablishmmentNameLocationId.Create("1182","Espaço 46",-8.042923M,-34.89445M),
EstablishmmentNameLocationId.Create("1183","Espaço Amitié",-8.049811M,-34.89934M),
EstablishmmentNameLocationId.Create("1184","Espaço Bia Designer Up",-7.988565M,-35.0479M),
EstablishmmentNameLocationId.Create("1185","Espaco Ciencia",-8.086564M,-34.89449M),
EstablishmmentNameLocationId.Create("1186","Espaço Mais Recife",-8.049049M,-34.88866M),
EstablishmmentNameLocationId.Create("1187","Espaço Marfim",-7.974934M,-34.84773M),
EstablishmmentNameLocationId.Create("1188","Espaço Nabuco",-8.028347M,-34.91811M),
EstablishmmentNameLocationId.Create("1189","Espaço Oxente Delivery",-7.918035M,-34.92089M),
EstablishmmentNameLocationId.Create("1190","Espaço Tamarineira",-8.028323M,-34.89941M),
EstablishmmentNameLocationId.Create("1191","Espinheiro Shopping",-8.045426M,-34.8962M),
EstablishmmentNameLocationId.Create("1192","Estação café",-8.01479M,-34.85257M),
EstablishmmentNameLocationId.Create("1193","Estação Quatro Cantos - Galeria & Café",-8.01479M,-34.85257M),
EstablishmmentNameLocationId.Create("1194","Estetica do Animal Pet Shop",-7.992163M,-35.04547M),
EstablishmmentNameLocationId.Create("1195","Estofados Brasil MB",-7.995026M,-34.84362M),
EstablishmmentNameLocationId.Create("1196","Estofados E Capotaria Brasil",-7.927115M,-34.82234M),
EstablishmmentNameLocationId.Create("1197","Estrela Pet-AquitemPE",-7.894669M,-34.90188M),
EstablishmmentNameLocationId.Create("1198","Estúdio 109 (espaço colaborativo)",-8.042038M,-34.88995M),
EstablishmmentNameLocationId.Create("1199","EVS_CAXANGA",-8.039735M,-34.94099M),
EstablishmmentNameLocationId.Create("1200","Express Shopping",-8.52726M,-35.00761M),
EstablishmmentNameLocationId.Create("1201","Expresso Cidadão da Boa Vista",-8.059321M,-34.88198M),
EstablishmmentNameLocationId.Create("1202","Fabbrique Pastificio",-8.035534M,-34.92095M),
EstablishmmentNameLocationId.Create("1203","Farmashopping",-8.0523M,-34.89883M),
EstablishmmentNameLocationId.Create("1204","Fenea",-7.938967M,-34.87763M),
EstablishmmentNameLocationId.Create("1205","Ferreiro Café",-8.119221M,-34.90543M),
EstablishmmentNameLocationId.Create("1206","Finesse Center",-8.136852M,-34.91419M),
EstablishmmentNameLocationId.Create("1207","Fred's Pizza",-7.899764M,-34.90744M),
EstablishmmentNameLocationId.Create("1208","Fridda Café Boa Viagem",-8.126699M,-34.90457M),
EstablishmmentNameLocationId.Create("1209","Fri-Sabor",-8.037731M,-34.87193M),
EstablishmmentNameLocationId.Create("1210","Galeria 30",-8.039819M,-34.89257M),
EstablishmmentNameLocationId.Create("1211","Galeria Alameda João de barros",-8.041603M,-34.89102M),
EstablishmmentNameLocationId.Create("1212","Galeria Amanda Maranhão",-8.036575M,-34.93512M),
EstablishmmentNameLocationId.Create("1213","Galeria Armindo Moura",-8.149339M,-34.91284M),
EstablishmmentNameLocationId.Create("1214","Galeria Bela Vista",-8.015694M,-35.01563M),
EstablishmmentNameLocationId.Create("1215","Galeria Boulevard Center",-8.160336M,-34.91223M),
EstablishmmentNameLocationId.Create("1216","Galeria Brasil",-8.132553M,-34.90791M),
EstablishmmentNameLocationId.Create("1217","Galeria Business",-8.038738M,-34.90024M),
EstablishmmentNameLocationId.Create("1218","Galeria Casa Grande",-8.031154M,-34.90579M),
EstablishmmentNameLocationId.Create("1219","Galeria Centro Sul",-8.10227M,-34.88801M),
EstablishmmentNameLocationId.Create("1220","Galeria Cidade do Porto",-8.105554M,-34.88942M),
EstablishmmentNameLocationId.Create("1221","Galeria Conselheiro Portela Center",-8.040121M,-34.89279M),
EstablishmmentNameLocationId.Create("1222","Galeria Cordeiro",-8.009984M,-34.84287M),
EstablishmmentNameLocationId.Create("1223","Galeria Crystal Center",-8.038527M,-34.90444M),
EstablishmmentNameLocationId.Create("1224","Galeria D' Bel",-8.035889M,-34.89745M),
EstablishmmentNameLocationId.Create("1225","Galeria da Beleza",-8.135699M,-34.90569M),
EstablishmmentNameLocationId.Create("1226","Galeria Danielle Center",-8.031901M,-34.88172M),
EstablishmmentNameLocationId.Create("1227","Galeria De Aldeia Center",-7.94704M,-35.02272M),
EstablishmmentNameLocationId.Create("1228","Galeria de Serviços",-8.04455M,-34.94727M),
EstablishmmentNameLocationId.Create("1229","Galeria Derby Center 2",-8.052187M,-34.89916M),
EstablishmmentNameLocationId.Create("1230","Galeria Do Calçadão",-8.505693M,-35.00248M),
EstablishmmentNameLocationId.Create("1231","Galeria Dumont Center",-8.037229M,-34.89841M),
EstablishmmentNameLocationId.Create("1232","Galeria Esquina 28",-8.044681M,-34.89561M),
EstablishmmentNameLocationId.Create("1233","Galeria Estação Jaqueira",-8.037597M,-34.90231M),
EstablishmmentNameLocationId.Create("1234","Galeria Extra Boa Viagem",-8.12676M,-34.89948M),
EstablishmmentNameLocationId.Create("1235","Galeria Ferraz de Abreu",-8.029111M,-34.91711M),
EstablishmmentNameLocationId.Create("1236","Galeria Futura",-8.100957M,-34.88652M),
EstablishmmentNameLocationId.Create("1237","Galeria Hora 100",-8.042645M,-34.89184M),
EstablishmmentNameLocationId.Create("1238","Galeria Hora Center",-8.044709M,-34.89281M),
EstablishmmentNameLocationId.Create("1239","Galeria Jardim",-8.133835M,-34.90358M),
EstablishmmentNameLocationId.Create("1240","Galeria João de Deus",-8.035213M,-34.89863M),
EstablishmmentNameLocationId.Create("1241","Galeria Júlia Campos",-8.02472M,-34.8937M),
EstablishmmentNameLocationId.Create("1242","Galeria KM 10",-7.973925M,-34.99771M),
EstablishmmentNameLocationId.Create("1243","Galeria Mário Melo",-8.045122M,-34.89392M),
EstablishmmentNameLocationId.Create("1244","Galeria Marques de Olinda",-8.002656M,-34.84015M),
EstablishmmentNameLocationId.Create("1245","Galeria Nazaré",-8.017916M,-34.96335M),
EstablishmmentNameLocationId.Create("1246","Galeria Nossa Senhora de Fátima",-8.028044M,-34.88239M),
EstablishmmentNameLocationId.Create("1247","Galeria Pão de Açúcar Rosa e Silva",-8.046275M,-34.89653M),
EstablishmmentNameLocationId.Create("1248","Galeria Parnamirim Center",-8.033188M,-34.90992M),
EstablishmmentNameLocationId.Create("1249","Galeria Pontevedra",-8.133013M,-34.91125M),
EstablishmmentNameLocationId.Create("1250","Galeria Pop Center",-8.138179M,-34.91356M),
EstablishmmentNameLocationId.Create("1251","Galeria Record",-8.019986M,-34.90688M),
EstablishmmentNameLocationId.Create("1252","Galeria Rosa e Silva Center",-8.037663M,-34.90108M),
EstablishmmentNameLocationId.Create("1253","Galeria San Rafael Center",-8.126049M,-34.89845M),
EstablishmmentNameLocationId.Create("1254","Galeria Santa Terezinha",-8.02951M,-34.88195M),
EstablishmmentNameLocationId.Create("1255","Galeria São Mateus",-8.10336M,-34.88913M),
EstablishmmentNameLocationId.Create("1256","Galeria Topázio",-7.906236M,-34.90908M),
EstablishmmentNameLocationId.Create("1257","Galeria Via Apia",-8.026336M,-34.91357M),
EstablishmmentNameLocationId.Create("1258","Galeria Via Venelli",-8.036931M,-34.89783M),
EstablishmmentNameLocationId.Create("1259","Galeria Village Santa Maria",-8.103767M,-34.88824M),
EstablishmmentNameLocationId.Create("1260","Gallery Joan of Arc",-8.088727M,-34.88563M),
EstablishmmentNameLocationId.Create("1261","Garagem Tapiocaria Café",-7.930711M,-34.89311M),
EstablishmmentNameLocationId.Create("1262","Gol Rações",-7.773464M,-34.89576M),
EstablishmmentNameLocationId.Create("1263","Goodyear do Brasil Produtos Borracha",-7.934422M,-34.86872M),
EstablishmmentNameLocationId.Create("1264","Graças Center",-8.045115M,-34.89883M),
EstablishmmentNameLocationId.Create("1265","Grão Espresso",-8.085907M,-34.89441M),
EstablishmmentNameLocationId.Create("1266","Grão Espresso Cafeteria - Boa Viagem - EXTRA",-8.104602M,-34.88993M),
EstablishmmentNameLocationId.Create("1267","Grão Espresso Casa Forte",-8.038702M,-34.9126M),
EstablishmmentNameLocationId.Create("1268","GrãoCheff",-8.045614M,-34.89385M),
EstablishmmentNameLocationId.Create("1269","Grupo Best do Brasil",-8.029228M,-34.91502M),
EstablishmmentNameLocationId.Create("1270","Grupo Executivo Digital - GED",-8.127211M,-34.91174M),
EstablishmmentNameLocationId.Create("1271","Grupo JCPM",-8.0895M,-34.88202M),
EstablishmmentNameLocationId.Create("1272","H.S Cabral Soluções em Descartáveis.",-8.069612M,-34.99798M),
EstablishmmentNameLocationId.Create("1273","HANGAR C3 Coworking",-8.12106M,-34.90573M),
EstablishmmentNameLocationId.Create("1274","Harina Café",-8.106516M,-34.88892M),
EstablishmmentNameLocationId.Create("1275","Havanna café",-8.086499M,-34.89296M),
EstablishmmentNameLocationId.Create("1276","Hélio Henriques Empresarial",-8.040311M,-34.91486M),
EstablishmmentNameLocationId.Create("1277","Hering Store Paulista North Way Shopping",-7.938374M,-34.8774M),
EstablishmmentNameLocationId.Create("1278","hoomi",-8.064829M,-34.87388M),
EstablishmmentNameLocationId.Create("1279","HR Haluli",-8.08791M,-34.88643M),
EstablishmmentNameLocationId.Create("1280","Hub 4Design",-8.099373M,-34.88737M),
EstablishmmentNameLocationId.Create("1281","Ibgm",-8.118945M,-34.90483M),
EstablishmmentNameLocationId.Create("1282","Iklecyo Permutas",-8.015334M,-35.03899M),
EstablishmmentNameLocationId.Create("1283","Impact Hub",-8.061823M,-34.87155M),
EstablishmmentNameLocationId.Create("1284","Impact Hub Boa Viagem",-8.113142M,-34.8946M),
EstablishmmentNameLocationId.Create("1285","Impact Hub Casa Forte",-8.035842M,-34.91895M),
EstablishmmentNameLocationId.Create("1286","Impact Hub Recife",-8.064811M,-34.87383M),
EstablishmmentNameLocationId.Create("1287","Impact Hub Várzea",-8.050054M,-34.96178M),
EstablishmmentNameLocationId.Create("1288","Intensivo Preparatórios",-7.99507M,-35.04241M),
EstablishmmentNameLocationId.Create("1289","Interagir Assessoria",-8.089478M,-34.88194M),
EstablishmmentNameLocationId.Create("1290","Interative Business Center",-16.69961M,-49.26404M),
EstablishmmentNameLocationId.Create("1291","Ipojuca Shopping",-8.400183M,-35.06327M),
EstablishmmentNameLocationId.Create("1292","Ipuera Center",-8.033013M,-34.93451M),
EstablishmmentNameLocationId.Create("1293","ItCoffee",-8.088682M,-34.88413M),
EstablishmmentNameLocationId.Create("1294","ITs HUB Coworking",-8.035842M,-34.91483M),
EstablishmmentNameLocationId.Create("1295","IWI Coworking",-7.989985M,-34.84111M),
EstablishmmentNameLocationId.Create("1296","Jack Alves sobraselhas",-7.999722M,-34.92179M),
EstablishmmentNameLocationId.Create("1297","Jump Brasil",-8.060618M,-34.87209M),
EstablishmmentNameLocationId.Create("1298","Karina Leão",-8.037967M,-34.87187M),
EstablishmmentNameLocationId.Create("1299","Kelly Restaurante",-7.844324M,-34.90763M),
EstablishmmentNameLocationId.Create("1300","KITANDA ANDRÉ",-7.87217M,-34.90659M),
EstablishmmentNameLocationId.Create("1301","Lá padoca",-8.093898M,-35.0221M),
EstablishmmentNameLocationId.Create("1302","Lala Café & Kitchen Affective",-8.044724M,-34.89951M),
EstablishmmentNameLocationId.Create("1303","Lanchonete e Caldo de Cana Cana Caiana",-8.024597M,-34.91762M),
EstablishmmentNameLocationId.Create("1304","Largo da Praça do Sebo",-8.063088M,-34.87894M),
EstablishmmentNameLocationId.Create("1305","Leandro oliveira tattoo",-7.775208M,-34.89694M),
EstablishmmentNameLocationId.Create("1306","Lee7",-8.019701M,-34.92714M),
EstablishmmentNameLocationId.Create("1307","Lilian rose micropigmentacao",-8.010051M,-34.93461M),
EstablishmmentNameLocationId.Create("1308","Livraria Jaqueira",-8.037203M,-34.90275M),
EstablishmmentNameLocationId.Create("1309","LOJA ATUAL MÓVEIS e Eletros",-7.99805M,-35.03527M),
EstablishmmentNameLocationId.Create("1310","Loja Claro",-8.016083M,-34.97797M),
EstablishmmentNameLocationId.Create("1311","Lojas império eletros",-8.086513M,-34.89086M),
EstablishmmentNameLocationId.Create("1312","Lojas Romanel",-8.06987M,-34.87938M),
EstablishmmentNameLocationId.Create("1313","LR bolsas",-8.067312M,-34.87803M),
EstablishmmentNameLocationId.Create("1314","Luxcar Locadora",-8.129465M,-34.90488M),
EstablishmmentNameLocationId.Create("1315","Luz E Vida",-8.118945M,-34.90483M),
EstablishmmentNameLocationId.Create("1316","Maje do Nordeste Ind e Com de Materiais Elétricos",-7.980568M,-35.06273M),
EstablishmmentNameLocationId.Create("1317","Malakoff Café - Paço do Frevo",-8.061395M,-34.87147M),
EstablishmmentNameLocationId.Create("1318","Malakoff Café Gourmet",-8.062251M,-34.91116M),
EstablishmmentNameLocationId.Create("1319","Malik Café & Cozinha",-8.11013M,-34.89336M),
EstablishmmentNameLocationId.Create("1320","Manacá Grill",-7.99285M,-35.04396M),
EstablishmmentNameLocationId.Create("1321","Mandacaru Cafe Arte Net",-8.506599M,-35.00129M),
EstablishmmentNameLocationId.Create("1322","MANICORES CAMARAGIBE - PRODUTOS PARA UNHA EM GEL",-8.023062M,-34.98293M),
EstablishmmentNameLocationId.Create("1323","Maraca's Coffee Bar",-8.525516M,-35.00813M),
EstablishmmentNameLocationId.Create("1324","Maria Lanches",-7.95932M,-34.84252M),
EstablishmmentNameLocationId.Create("1325","Maricota Burgueria e Pizzaria",-7.907345M,-34.90442M),
EstablishmmentNameLocationId.Create("1326","MARIPÁ colab",-8.040806M,-34.90046M),
EstablishmmentNameLocationId.Create("1327","Marrom Glacê",-7.910046M,-34.90207M),
EstablishmmentNameLocationId.Create("1328","Mascate Café e Negócios",-8.131693M,-34.90369M),
EstablishmmentNameLocationId.Create("1329","Massala Café",-8.052685M,-34.9021M),
EstablishmmentNameLocationId.Create("1330","Matsu",-7.559977M,-34.9973M),
EstablishmmentNameLocationId.Create("1331","Memo Barber",-8.035612M,-34.92313M),
EstablishmmentNameLocationId.Create("1332","Mente Fértil Colab",-8.017833M,-34.8536M),
EstablishmmentNameLocationId.Create("1333","Metropolitan Association of Cyclists of Grande Recife",-8.034615M,-34.8961M),
EstablishmmentNameLocationId.Create("1334","Micamarí",-8.019975M,-34.99177M),
EstablishmmentNameLocationId.Create("1335","Mini Carros",-8.037895M,-34.8719M),
EstablishmmentNameLocationId.Create("1336","Mini Shopping da Carne",-7.998016M,-35.0394M),
EstablishmmentNameLocationId.Create("1337","Mix Açaiteria",-7.921555M,-34.93102M),
EstablishmmentNameLocationId.Create("1338","Mobibrasil",-8.005413M,-35.01991M),
EstablishmmentNameLocationId.Create("1339","Modul Espaço Coworking",-16.68758M,-49.26223M),
EstablishmmentNameLocationId.Create("1340","Molita Coffee",-7.96273M,-35.00882M),
EstablishmmentNameLocationId.Create("1341","Mon Cher Café Et Patisserie",-8.054641M,-34.88812M),
EstablishmmentNameLocationId.Create("1342","Morana Paulista",-7.938401M,-34.87785M),
EstablishmmentNameLocationId.Create("1343","Mr Black Café",-7.994318M,-34.84059M),
EstablishmmentNameLocationId.Create("1344","Mr. Fit Jaqueira",-8.038531M,-34.90462M),
EstablishmmentNameLocationId.Create("1345","Mr. Mix Milk Shakes",-7.829645M,-34.90935M),
EstablishmmentNameLocationId.Create("1346","Multi Center Parnamirim",-8.031656M,-34.90955M),
EstablishmmentNameLocationId.Create("1347","Multioffice - Escritório Virtual",-8.03114M,-34.92394M),
EstablishmmentNameLocationId.Create("1348","Mundinho VIP (Casa de festa KIDS e TEEN)",-8.042006M,-34.89867M),
EstablishmmentNameLocationId.Create("1349","Na Venda Chocolates e Café",-8.045255M,-34.89859M),
EstablishmmentNameLocationId.Create("1350","Nai Tiaras",-8.005213M,-34.93589M),
EstablishmmentNameLocationId.Create("1352","NC Comércio e Importação",-8.033247M,-34.92176M),
EstablishmmentNameLocationId.Create("1353","Nenus hair",-8.093918M,-34.88688M),
EstablishmmentNameLocationId.Create("1354","New Cell-Revenda Oi-Shopping Plaza",-8.036991M,-34.9125M),
EstablishmmentNameLocationId.Create("1355","night run - recife etapa rock",-8.054074M,-34.87085M),
EstablishmmentNameLocationId.Create("1356","Nós Coworking Recife",-8.064811M,-34.87383M),
EstablishmmentNameLocationId.Create("1357","O Boticário",-8.016409M,-34.97673M),
EstablishmmentNameLocationId.Create("1358","O Pátio Café & Cozinha",-8.050605M,-34.89782M),
EstablishmmentNameLocationId.Create("1359","Olinda Café & Cervejaria",-7.992218M,-34.83916M),
EstablishmmentNameLocationId.Create("1360","Olinda Coffee Place",-8.010003M,-34.862M),
EstablishmmentNameLocationId.Create("1361","Olinda Shopping",-7.997377M,-34.83991M),
EstablishmmentNameLocationId.Create("1362","OnTime Café & Conveniência",-8.034911M,-34.90219M),
EstablishmmentNameLocationId.Create("1363","Ótica Garcia's",-8.021842M,-34.91631M),
EstablishmmentNameLocationId.Create("1364","Paço Alfândega Shopping",-8.064894M,-34.87381M),
EstablishmmentNameLocationId.Create("1365","Padaria",-8.024577M,-34.92383M),
EstablishmmentNameLocationId.Create("1366","Padaria Guarany",-7.560016M,-34.99522M),
EstablishmmentNameLocationId.Create("1367","Panlanches",-7.90939M,-34.9015M),
EstablishmmentNameLocationId.Create("1368","Parada do Açaí",-7.996566M,-35.03721M),
EstablishmmentNameLocationId.Create("1369","Park Center",-8.037673M,-34.90284M),
EstablishmmentNameLocationId.Create("1370","Patas Love",-8.005643M,-34.87112M),
EstablishmmentNameLocationId.Create("1371","Patteo Olinda Shopping",-7.993619M,-34.84135M),
EstablishmmentNameLocationId.Create("1372","Patty Cafeteria",-7.992062M,-34.84174M),
EstablishmmentNameLocationId.Create("1373","Pau Brasil Center",-7.992395M,-35.04196M),
EstablishmmentNameLocationId.Create("1374","Paula Cestas Finas",-7.900295M,-34.90047M),
EstablishmmentNameLocationId.Create("1375","Paulista North Way Shopping",-7.938289M,-34.8778M),
EstablishmmentNameLocationId.Create("1376","Pellicano Caffè",-8.034803M,-34.91891M),
EstablishmmentNameLocationId.Create("1377","Pequenos Moleques",-8.118945M,-34.90483M),
EstablishmmentNameLocationId.Create("1378","Pernambuco Motos Abreu e Lima",-7.909755M,-34.90147M),
EstablishmmentNameLocationId.Create("1379","Pet Brasil",-7.931423M,-34.89429M),
EstablishmmentNameLocationId.Create("1380","Pet Planet",-7.998133M,-35.04248M),
EstablishmmentNameLocationId.Create("1381","Pet Shopping",-7.952872M,-34.85133M),
EstablishmmentNameLocationId.Create("1382","Piedade Center",-8.158804M,-34.91264M),
EstablishmmentNameLocationId.Create("1383","Piratas da Praia Hostel CoWorking - Recife",-8.107682M,-34.88995M),
EstablishmmentNameLocationId.Create("1384","Pixel Café",-7.990481M,-34.84073M),
EstablishmmentNameLocationId.Create("1385","Pizzaria Atlântico",-8.015054M,-34.97795M),
EstablishmmentNameLocationId.Create("1386","PlexosEscritório Virtual & Coworking ",-8.034615M,-34.8961M),
EstablishmmentNameLocationId.Create("1387","Ponto Natural",-8.118945M,-34.90483M),
EstablishmmentNameLocationId.Create("1388","PORTAL - PONTE",-8.11487M,-34.90718M),
EstablishmmentNameLocationId.Create("1389","Portal Surf Av Brasil",-7.952684M,-34.85125M),
EstablishmmentNameLocationId.Create("1390","Porto do Cafe",-8.038705M,-34.89961M),
EstablishmmentNameLocationId.Create("1391","PORTO PRIMO - Delicatessen e Restaurante",-7.962263M,-35.00879M),
EstablishmmentNameLocationId.Create("1392","Praia Sul Shopping",-8.130069M,-34.90132M),
EstablishmmentNameLocationId.Create("1393","PUA doceria experimental",-8.017757M,-34.85233M),
EstablishmmentNameLocationId.Create("1394","PVC liner Brazil",-7.931213M,-34.88797M),
EstablishmmentNameLocationId.Create("1395","RB - Recepção Bulevar",-7.992005M,-35.04265M),
EstablishmmentNameLocationId.Create("1396","Recife",-8.04372M,-34.94419M),
EstablishmmentNameLocationId.Create("1397","Red Bake",-8.118945M,-34.90483M),
EstablishmmentNameLocationId.Create("1398","Rede 344",-8.030774M,-34.92119M),
EstablishmmentNameLocationId.Create("1399","Regus",-8.116292M,-34.90261M),
EstablishmmentNameLocationId.Create("1400","Regus - Recife, JCPM Trade Center -Boa Viagem - Pina",-8.08946M,-34.88199M),
EstablishmmentNameLocationId.Create("1401","Renor Office Escritório Virtual Boa Viagem",-8.123886M,-34.90501M),
EstablishmmentNameLocationId.Create("1402","Renor Office Unidade Rio Mar",-8.087336M,-34.89155M),
EstablishmmentNameLocationId.Create("1403","Renor Office Virtual Office & Coworking",-8.086692M,-34.89317M),
EstablishmmentNameLocationId.Create("1404","Reserva Shopping",-8.024772M,-35.03965M),
EstablishmmentNameLocationId.Create("1405","Residential Park Capibaribe 2",-8.011163M,-35.03755M),
EstablishmmentNameLocationId.Create("1406","Restaurante Catarinense",-7.917175M,-34.89745M),
EstablishmmentNameLocationId.Create("1407","Restaurante China 25",-7.87391M,-34.90715M),
EstablishmmentNameLocationId.Create("1408","Restaurante e Café Bella Apetite",-7.941731M,-34.8838M),
EstablishmmentNameLocationId.Create("1409","Restaurante Pitanga Sabores da Terra",-8.504601M,-35.00398M),
EstablishmmentNameLocationId.Create("1410","Rio Mar",-8.08564M,-34.89389M),
EstablishmmentNameLocationId.Create("1411","RioMar",-8.08572M,-34.89368M),
EstablishmmentNameLocationId.Create("1412","Ripe Café",-8.03024M,-34.92258M),
EstablishmmentNameLocationId.Create("1413","Roma Cafe e Bistro",-7.558396M,-34.9991M),
EstablishmmentNameLocationId.Create("1414","Rooftop Tacaruna",-8.037402M,-34.87204M),
EstablishmmentNameLocationId.Create("1415","Route Açaí Service",-8.14486M,-34.90789M),
EstablishmmentNameLocationId.Create("1416","Sabor Da Casa Café - Praça De Boa Viagem",-8.131652M,-34.9011M),
EstablishmmentNameLocationId.Create("1417","Sabor da Casa Café- Bolo de Rolo",-8.50589M,-35.00298M),
EstablishmmentNameLocationId.Create("1418","San Paolo",-8.118945M,-34.90483M),
EstablishmmentNameLocationId.Create("1419","Santo Doce",-8.042632M,-34.89888M),
EstablishmmentNameLocationId.Create("1420","São Braz",-8.125978M,-34.89936M),
EstablishmmentNameLocationId.Create("1421","São Braz Coffee Shop",-8.114546M,-34.89605M),
EstablishmmentNameLocationId.Create("1422","São Braz Coffee Shopp (Graças)",-8.05098M,-34.9013M),
EstablishmmentNameLocationId.Create("1423","São Braz Patteo Olinda",-7.993604M,-34.84119M),
EstablishmmentNameLocationId.Create("1424","Senhora Torta Café & Patisserie",-8.033312M,-34.92036M),
EstablishmmentNameLocationId.Create("1425","Sergio P.S.neto",-8.073833M,-35.00139M),
EstablishmmentNameLocationId.Create("1426","Seven Wonders Café",-8.086055M,-34.89508M),
EstablishmmentNameLocationId.Create("1427","Sex shop Amor & Sexo",-7.90943M,-34.90218M),
EstablishmmentNameLocationId.Create("1428","Shompping Center De Aldeia",-7.962247M,-35.00896M),
EstablishmmentNameLocationId.Create("1429","Shopping Caruaru",-7.91826M,-34.92137M),
EstablishmmentNameLocationId.Create("1430","Shopping Do Automovel De Pernanbuco",-8.086136M,-34.87939M),
EstablishmmentNameLocationId.Create("1431","Shopping do Porto",-8.504943M,-35.0023M),
EstablishmmentNameLocationId.Create("1432","Shopping ETC",-8.038522M,-34.89951M),
EstablishmmentNameLocationId.Create("1433","Shopping Galeria Camaragibe",-8.021292M,-34.98444M),
EstablishmmentNameLocationId.Create("1434","Shopping Guararapes",-8.168619M,-34.91953M),
EstablishmmentNameLocationId.Create("1435","Shopping Igarassu",-7.827502M,-34.90916M),
EstablishmmentNameLocationId.Create("1436","Shopping Janga",-7.919427M,-34.82522M),
EstablishmmentNameLocationId.Create("1437","Shopping Norte Janga",-7.935512M,-34.82546M),
EstablishmmentNameLocationId.Create("1438","Shopping Plaza - Casa Forte",-8.037065M,-34.91253M),
EstablishmmentNameLocationId.Create("1439","Shopping Recife",-8.119123M,-34.90499M),
EstablishmmentNameLocationId.Create("1440","Shopping Tacaruna",-8.03751M,-34.87178M),
EstablishmmentNameLocationId.Create("1441","Shop's Show",-8.103976M,-34.88783M),
EstablishmmentNameLocationId.Create("1442","Silva Café & Comedoria",-8.026896M,-34.91538M),
EstablishmmentNameLocationId.Create("1443","Simone Barros - Doceria",-8.037902M,-34.91965M),
EstablishmmentNameLocationId.Create("1444","Simone Barros Doceria",-7.929568M,-34.82343M),
EstablishmmentNameLocationId.Create("1445","Sinspire",-8.060813M,-34.87158M),
EstablishmmentNameLocationId.Create("1446","SmartOffice - Escritórios Inteligentes / Coworking",-8.055508M,-34.88615M),
EstablishmmentNameLocationId.Create("1447","Sos Cabelos",-8.023767M,-34.99525M),
EstablishmmentNameLocationId.Create("1448","Spaço K",-8.111149M,-34.89277M),
EstablishmmentNameLocationId.Create("1449","Squina 48",-8.039042M,-34.89468M),
EstablishmmentNameLocationId.Create("1450","Studio Bia designer up",-7.993602M,-35.04347M),
EstablishmmentNameLocationId.Create("1451","Sweets Café Big Bompreço Casa Forte",-8.037002M,-34.91388M),
EstablishmmentNameLocationId.Create("1452","Sweets Café Shopping RioMar",-8.08649M,-34.89408M),
EstablishmmentNameLocationId.Create("1453","Tacafome",-7.904745M,-34.90266M),
EstablishmmentNameLocationId.Create("1454","Tasco Coffee Drinks",-8.447265M,-34.98566M),
EstablishmmentNameLocationId.Create("1455","Tattooaria 21",-7.9097M,-34.90189M),
EstablishmmentNameLocationId.Create("1456","Tea with Cheetah",-8.030849M,-34.92473M),
EstablishmmentNameLocationId.Create("1457","Templo Do Corte",-8.040083M,-34.89295M),
EstablishmmentNameLocationId.Create("1458","The American Coffee And Cake, Co.",-8.119011M,-34.90459M),
EstablishmmentNameLocationId.Create("1459","The Garden Open Mall",-8.161009M,-34.91288M),
EstablishmmentNameLocationId.Create("1460","The Lab Recife - Coworking e Espaço Colaborativo",-8.132961M,-34.90317M),
EstablishmmentNameLocationId.Create("1461","TIJOLO DE FÁBRICA",-7.774061M,-34.89872M),
EstablishmmentNameLocationId.Create("1462","Tokyo's Café",-8.03856M,-34.90098M),
EstablishmmentNameLocationId.Create("1463","Torre Empresarial Center II",-8.044603M,-34.90837M),
EstablishmmentNameLocationId.Create("1464","Trinus Office Consultório e Escritório Virtuais",-8.029544M,-34.92152M),
EstablishmmentNameLocationId.Create("1465","Triton",-8.037967M,-34.87187M),
EstablishmmentNameLocationId.Create("1466","Usina Solar de São Lourenço da Mata",-8.040984M,-35.01298M),
EstablishmmentNameLocationId.Create("1467","Varejão das Fraldas Cordeiro",-8.052155M,-34.91936M),
EstablishmmentNameLocationId.Create("1468","Varejão dos Presentes",-7.773722M,-34.89701M),
EstablishmmentNameLocationId.Create("1469","VERO Caffè e Vino",-8.036775M,-34.91248M),
EstablishmmentNameLocationId.Create("1470","Versado Coffee Store",-8.031461M,-34.91473M),
EstablishmmentNameLocationId.Create("1471","Via Roma Center",-8.032699M,-34.90995M),
EstablishmmentNameLocationId.Create("1472","Vicalli",-8.113158M,-34.89824M),
EstablishmmentNameLocationId.Create("1473","Vila do pé",-8.015054M,-34.97795M),
EstablishmmentNameLocationId.Create("1474","Villa Engenho - Hamburguers Artesanais e Comida Regional",-8.019618M,-34.98299M),
EstablishmmentNameLocationId.Create("1475","Virtua Centro",-8.06114M,-34.88117M),
EstablishmmentNameLocationId.Create("1476","Virtua Conselheiro Aguiar",-8.127557M,-34.89987M),
EstablishmmentNameLocationId.Create("1477","Virtua Excelsior",-8.125329M,-34.89901M),
EstablishmmentNameLocationId.Create("1478","Virtua Pina",-8.100657M,-34.88847M),
EstablishmmentNameLocationId.Create("1479","virtual shopping",-8.008421M,-34.92913M),
EstablishmmentNameLocationId.Create("1480","Vivant Consultórios",-8.131208M,-34.90318M),
EstablishmmentNameLocationId.Create("1481","Vivart Moda Café",-8.041386M,-34.89183M),
EstablishmmentNameLocationId.Create("1482","WILK DEYVSON TATTOO",-7.963887M,-34.8412M),
EstablishmmentNameLocationId.Create("1483","Work Madalena",-8.053333M,-34.91317M),
EstablishmmentNameLocationId.Create("1484","Workhall Coworking Parnamirim",-8.033419M,-34.90972M),
EstablishmmentNameLocationId.Create("1485","Workhall Coworking Rosa e Silva",-8.038548M,-34.89955M),
EstablishmmentNameLocationId.Create("1486","Workspot Coworking",-8.039973M,-34.90067M),
EstablishmmentNameLocationId.Create("1487","Xêro Café e Arte",-8.00645M,-34.84352M),
EstablishmmentNameLocationId.Create("1488","Zeca's Sorvetes",-7.92366M,-34.90496M),
EstablishmmentNameLocationId.Create("1489","ZOCO",-7.98918M,-34.8405M),
EstablishmmentNameLocationId.Create("1490","ZV Tattoo e Galeria",-8.088754M,-34.88564M),


};

            _establishmment.AddEstaBlishment(list);

        }

    }
}
