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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListCalcEnginesResponseUnmarshaller
    {
        public static ListCalcEnginesResponse Unmarshall(UnmarshallerContext context)
        {
			ListCalcEnginesResponse listCalcEnginesResponse = new ListCalcEnginesResponse();

			listCalcEnginesResponse.HttpResponse = context.HttpResponse;
			listCalcEnginesResponse.HttpStatusCode = context.IntegerValue("ListCalcEngines.HttpStatusCode");
			listCalcEnginesResponse.Success = context.BooleanValue("ListCalcEngines.Success");
			listCalcEnginesResponse.RequestId = context.StringValue("ListCalcEngines.RequestId");

			ListCalcEnginesResponse.ListCalcEngines_Data data = new ListCalcEnginesResponse.ListCalcEngines_Data();
			data.PageNumber = context.IntegerValue("ListCalcEngines.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListCalcEngines.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListCalcEngines.Data.TotalCount");

			List<ListCalcEnginesResponse.ListCalcEngines_Data.ListCalcEngines_CalcEnginesItem> data_calcEngines = new List<ListCalcEnginesResponse.ListCalcEngines_Data.ListCalcEngines_CalcEnginesItem>();
			for (int i = 0; i < context.Length("ListCalcEngines.Data.CalcEngines.Length"); i++) {
				ListCalcEnginesResponse.ListCalcEngines_Data.ListCalcEngines_CalcEnginesItem calcEnginesItem = new ListCalcEnginesResponse.ListCalcEngines_Data.ListCalcEngines_CalcEnginesItem();
				calcEnginesItem.CalcEngineType = context.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].CalcEngineType");
				calcEnginesItem.GmtCreate = context.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].GmtCreate");
				calcEnginesItem.DwRegion = context.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].DwRegion");
				calcEnginesItem.IsDefault = context.BooleanValue("ListCalcEngines.Data.CalcEngines["+ i +"].IsDefault");
				calcEnginesItem.BindingProjectId = context.IntegerValue("ListCalcEngines.Data.CalcEngines["+ i +"].BindingProjectId");
				calcEnginesItem.EnvType = context.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].EnvType");
				calcEnginesItem.TenantId = context.LongValue("ListCalcEngines.Data.CalcEngines["+ i +"].TenantId");
				calcEnginesItem.Name = context.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].Name");
				calcEnginesItem.BindingProjectName = context.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].BindingProjectName");
				calcEnginesItem.Region = context.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].Region");
				calcEnginesItem.EngineId = context.IntegerValue("ListCalcEngines.Data.CalcEngines["+ i +"].EngineId");
				calcEnginesItem.EngineInfo = context.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].EngineInfo");
				calcEnginesItem.TaskAuthType = context.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].TaskAuthType");

				data_calcEngines.Add(calcEnginesItem);
			}
			data.CalcEngines = data_calcEngines;
			listCalcEnginesResponse.Data = data;
        
			return listCalcEnginesResponse;
        }
    }
}
