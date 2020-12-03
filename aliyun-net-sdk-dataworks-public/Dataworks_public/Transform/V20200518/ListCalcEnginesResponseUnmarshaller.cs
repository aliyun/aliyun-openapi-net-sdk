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
        public static ListCalcEnginesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCalcEnginesResponse listCalcEnginesResponse = new ListCalcEnginesResponse();

			listCalcEnginesResponse.HttpResponse = _ctx.HttpResponse;
			listCalcEnginesResponse.HttpStatusCode = _ctx.IntegerValue("ListCalcEngines.HttpStatusCode");
			listCalcEnginesResponse.Success = _ctx.BooleanValue("ListCalcEngines.Success");
			listCalcEnginesResponse.RequestId = _ctx.StringValue("ListCalcEngines.RequestId");

			ListCalcEnginesResponse.ListCalcEngines_Data data = new ListCalcEnginesResponse.ListCalcEngines_Data();
			data.PageNumber = _ctx.IntegerValue("ListCalcEngines.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListCalcEngines.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListCalcEngines.Data.TotalCount");

			List<ListCalcEnginesResponse.ListCalcEngines_Data.ListCalcEngines_CalcEnginesItem> data_calcEngines = new List<ListCalcEnginesResponse.ListCalcEngines_Data.ListCalcEngines_CalcEnginesItem>();
			for (int i = 0; i < _ctx.Length("ListCalcEngines.Data.CalcEngines.Length"); i++) {
				ListCalcEnginesResponse.ListCalcEngines_Data.ListCalcEngines_CalcEnginesItem calcEnginesItem = new ListCalcEnginesResponse.ListCalcEngines_Data.ListCalcEngines_CalcEnginesItem();
				calcEnginesItem.CalcEngineType = _ctx.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].CalcEngineType");
				calcEnginesItem.GmtCreate = _ctx.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].GmtCreate");
				calcEnginesItem.DwRegion = _ctx.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].DwRegion");
				calcEnginesItem.IsDefault = _ctx.BooleanValue("ListCalcEngines.Data.CalcEngines["+ i +"].IsDefault");
				calcEnginesItem.BindingProjectId = _ctx.IntegerValue("ListCalcEngines.Data.CalcEngines["+ i +"].BindingProjectId");
				calcEnginesItem.EnvType = _ctx.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].EnvType");
				calcEnginesItem.TenantId = _ctx.LongValue("ListCalcEngines.Data.CalcEngines["+ i +"].TenantId");
				calcEnginesItem.Name = _ctx.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].Name");
				calcEnginesItem.BindingProjectName = _ctx.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].BindingProjectName");
				calcEnginesItem.Region = _ctx.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].Region");
				calcEnginesItem.EngineId = _ctx.IntegerValue("ListCalcEngines.Data.CalcEngines["+ i +"].EngineId");
				calcEnginesItem.EngineInfo = _ctx.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].EngineInfo");
				calcEnginesItem.TaskAuthType = _ctx.StringValue("ListCalcEngines.Data.CalcEngines["+ i +"].TaskAuthType");

				data_calcEngines.Add(calcEnginesItem);
			}
			data.CalcEngines = data_calcEngines;
			listCalcEnginesResponse.Data = data;
        
			return listCalcEnginesResponse;
        }
    }
}
