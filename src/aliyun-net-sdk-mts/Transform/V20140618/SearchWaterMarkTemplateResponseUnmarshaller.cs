/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SearchWaterMarkTemplateResponseUnmarshaller
    {
        public static SearchWaterMarkTemplateResponse Unmarshall(UnmarshallerContext context)
        {
            SearchWaterMarkTemplateResponse searchWaterMarkTemplateResponse = new SearchWaterMarkTemplateResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("SearchWaterMarkTemplate.RequestId"),
                TotalCount = context.LongValue("SearchWaterMarkTemplate.TotalCount"),
                PageNumber = context.LongValue("SearchWaterMarkTemplate.PageNumber"),
                PageSize = context.LongValue("SearchWaterMarkTemplate.PageSize")
            };
            List<SearchWaterMarkTemplateResponse.WaterMarkTemplate> waterMarkTemplateList = new List<SearchWaterMarkTemplateResponse.WaterMarkTemplate>();
			for (int i = 0; i < context.Length("SearchWaterMarkTemplate.WaterMarkTemplateList.Length"); i++) {
                SearchWaterMarkTemplateResponse.WaterMarkTemplate waterMarkTemplate = new SearchWaterMarkTemplateResponse.WaterMarkTemplate()
                {
                    Id = context.StringValue($"SearchWaterMarkTemplate.WaterMarkTemplateList[{i}].Id"),
                    Name = context.StringValue($"SearchWaterMarkTemplate.WaterMarkTemplateList[{i}].Name"),
                    Width = context.StringValue($"SearchWaterMarkTemplate.WaterMarkTemplateList[{i}].Width"),
                    Height = context.StringValue($"SearchWaterMarkTemplate.WaterMarkTemplateList[{i}].Height"),
                    Dx = context.StringValue($"SearchWaterMarkTemplate.WaterMarkTemplateList[{i}].Dx"),
                    Dy = context.StringValue($"SearchWaterMarkTemplate.WaterMarkTemplateList[{i}].Dy"),
                    ReferPos = context.StringValue($"SearchWaterMarkTemplate.WaterMarkTemplateList[{i}].ReferPos"),
                    Type = context.StringValue($"SearchWaterMarkTemplate.WaterMarkTemplateList[{i}].Type"),
                    State = context.StringValue($"SearchWaterMarkTemplate.WaterMarkTemplateList[{i}].State")
                };
                waterMarkTemplateList.Add(waterMarkTemplate);
			}
			searchWaterMarkTemplateResponse.WaterMarkTemplateList = waterMarkTemplateList;
        
			return searchWaterMarkTemplateResponse;
        }
    }
}