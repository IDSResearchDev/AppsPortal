using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AppsPortal.Models
{
    public class Product
    {
        public string programName { get; set; }
        public int programVersion { get; set; }
    }


    public class Projecta
    {
        public List<Project> Projects { get; set; }

        //IRestResponse response = new RestResponse();
        

        /*response.Content = @"[
                                    {
                                        ""Id"": 1,
                                        ""ProjectName"":""PackageTool"",
                                        ""Description"":""Test Description PackageTool"",
                                        ""Compatibility"":
                                                        [{""TeklaStructure"": ""20.0/21.0"", ""Windows"": ""7/8/8.1/10""}]
                                    },
                                    {
                                        ""Id"": 2,
                                        ""ProjectName"":""Model Launcher"",
                                        ""Description"":""Test Description Model Launcher"",
                                        ""Compatibility"":
                                                        [{""TeklaStructure"": ""19.0/20.0/21.0"", ""Windows"": ""7/8/8.1/10""}]
                                    }
                                 ]";*/

          //JsonDeserializer deserializer = new JsonDeserializer();

        void DeserializedJson()
        {
            //JsonConvert.DeserializeObject();
        }
    }

    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public List<Compatibility> Compatibility { get; set; }


    }

    public class Compatibility
    {
        public string TeklaStructure { get; set; }
        public string Windows { get; set; }

    }



}
