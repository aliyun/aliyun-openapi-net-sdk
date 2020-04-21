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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.ivpd.Model.V20190625;

namespace Aliyun.Acs.ivpd.Transform.V20190625
{
    public class ListPackageDesignModelTypesResponseUnmarshaller
    {
        public static ListPackageDesignModelTypesResponse Unmarshall(UnmarshallerContext context)
        {
			ListPackageDesignModelTypesResponse listPackageDesignModelTypesResponse = new ListPackageDesignModelTypesResponse();

			listPackageDesignModelTypesResponse.HttpResponse = context.HttpResponse;
			listPackageDesignModelTypesResponse.RequestId = context.StringValue("ListPackageDesignModelTypes.RequestId");
			listPackageDesignModelTypesResponse.Code = context.StringValue("ListPackageDesignModelTypes.Code");
			listPackageDesignModelTypesResponse.Message = context.StringValue("ListPackageDesignModelTypes.Message");

			ListPackageDesignModelTypesResponse.ListPackageDesignModelTypes_Data data = new ListPackageDesignModelTypesResponse.ListPackageDesignModelTypes_Data();

			List<ListPackageDesignModelTypesResponse.ListPackageDesignModelTypes_Data.ListPackageDesignModelTypes_ModelType> data_modelTypeList = new List<ListPackageDesignModelTypesResponse.ListPackageDesignModelTypes_Data.ListPackageDesignModelTypes_ModelType>();
			for (int i = 0; i < context.Length("ListPackageDesignModelTypes.Data.ModelTypeList.Length"); i++) {
				ListPackageDesignModelTypesResponse.ListPackageDesignModelTypes_Data.ListPackageDesignModelTypes_ModelType modelType = new ListPackageDesignModelTypesResponse.ListPackageDesignModelTypes_Data.ListPackageDesignModelTypes_ModelType();
				modelType.ModelType = context.StringValue("ListPackageDesignModelTypes.Data.ModelTypeList["+ i +"].ModelType");

				List<ListPackageDesignModelTypesResponse.ListPackageDesignModelTypes_Data.ListPackageDesignModelTypes_ModelType.ListPackageDesignModelTypes_Element> modelType_elements = new List<ListPackageDesignModelTypesResponse.ListPackageDesignModelTypes_Data.ListPackageDesignModelTypes_ModelType.ListPackageDesignModelTypes_Element>();
				for (int j = 0; j < context.Length("ListPackageDesignModelTypes.Data.ModelTypeList["+ i +"].Elements.Length"); j++) {
					ListPackageDesignModelTypesResponse.ListPackageDesignModelTypes_Data.ListPackageDesignModelTypes_ModelType.ListPackageDesignModelTypes_Element element = new ListPackageDesignModelTypesResponse.ListPackageDesignModelTypes_Data.ListPackageDesignModelTypes_ModelType.ListPackageDesignModelTypes_Element();
					element.SideName = context.StringValue("ListPackageDesignModelTypes.Data.ModelTypeList["+ i +"].Elements["+ j +"].SideName");

					modelType_elements.Add(element);
				}
				modelType.Elements = modelType_elements;

				data_modelTypeList.Add(modelType);
			}
			data.ModelTypeList = data_modelTypeList;
			listPackageDesignModelTypesResponse.Data = data;
        
			return listPackageDesignModelTypesResponse;
        }
    }
}
