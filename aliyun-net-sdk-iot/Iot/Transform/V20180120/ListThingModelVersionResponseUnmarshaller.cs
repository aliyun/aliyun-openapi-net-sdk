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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class ListThingModelVersionResponseUnmarshaller
    {
        public static ListThingModelVersionResponse Unmarshall(UnmarshallerContext context)
        {
			ListThingModelVersionResponse listThingModelVersionResponse = new ListThingModelVersionResponse();

			listThingModelVersionResponse.HttpResponse = context.HttpResponse;
			listThingModelVersionResponse.RequestId = context.StringValue("ListThingModelVersion.RequestId");
			listThingModelVersionResponse.Success = context.BooleanValue("ListThingModelVersion.Success");
			listThingModelVersionResponse.Code = context.StringValue("ListThingModelVersion.Code");
			listThingModelVersionResponse.ErrorMessage = context.StringValue("ListThingModelVersion.ErrorMessage");

			ListThingModelVersionResponse.ListThingModelVersion_Data data = new ListThingModelVersionResponse.ListThingModelVersion_Data();

			List<ListThingModelVersionResponse.ListThingModelVersion_Data.ListThingModelVersion_ModelVersion> data_modelVersions = new List<ListThingModelVersionResponse.ListThingModelVersion_Data.ListThingModelVersion_ModelVersion>();
			for (int i = 0; i < context.Length("ListThingModelVersion.Data.ModelVersions.Length"); i++) {
				ListThingModelVersionResponse.ListThingModelVersion_Data.ListThingModelVersion_ModelVersion modelVersion = new ListThingModelVersionResponse.ListThingModelVersion_Data.ListThingModelVersion_ModelVersion();
				modelVersion.ModelVersion = context.StringValue("ListThingModelVersion.Data.ModelVersions["+ i +"].ModelVersion");
				modelVersion.Description = context.StringValue("ListThingModelVersion.Data.ModelVersions["+ i +"].Description");
				modelVersion.GmtCreate = context.LongValue("ListThingModelVersion.Data.ModelVersions["+ i +"].GmtCreate");

				data_modelVersions.Add(modelVersion);
			}
			data.ModelVersions = data_modelVersions;
			listThingModelVersionResponse.Data = data;
        
			return listThingModelVersionResponse;
        }
    }
}
