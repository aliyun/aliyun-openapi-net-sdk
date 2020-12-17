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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class GetCustomizationConfigListResponseUnmarshaller
    {
        public static GetCustomizationConfigListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCustomizationConfigListResponse getCustomizationConfigListResponse = new GetCustomizationConfigListResponse();

			getCustomizationConfigListResponse.HttpResponse = _ctx.HttpResponse;
			getCustomizationConfigListResponse.RequestId = _ctx.StringValue("GetCustomizationConfigList.RequestId");
			getCustomizationConfigListResponse.Success = _ctx.BooleanValue("GetCustomizationConfigList.Success");
			getCustomizationConfigListResponse.Code = _ctx.StringValue("GetCustomizationConfigList.Code");
			getCustomizationConfigListResponse.Message = _ctx.StringValue("GetCustomizationConfigList.Message");

			List<GetCustomizationConfigListResponse.GetCustomizationConfigList_ModelCustomizationDataSetPo> getCustomizationConfigListResponse_data = new List<GetCustomizationConfigListResponse.GetCustomizationConfigList_ModelCustomizationDataSetPo>();
			for (int i = 0; i < _ctx.Length("GetCustomizationConfigList.Data.Length"); i++) {
				GetCustomizationConfigListResponse.GetCustomizationConfigList_ModelCustomizationDataSetPo modelCustomizationDataSetPo = new GetCustomizationConfigListResponse.GetCustomizationConfigList_ModelCustomizationDataSetPo();
				modelCustomizationDataSetPo.ModelId = _ctx.LongValue("GetCustomizationConfigList.Data["+ i +"].ModelId");
				modelCustomizationDataSetPo.ModeCustomizationId = _ctx.StringValue("GetCustomizationConfigList.Data["+ i +"].ModeCustomizationId");
				modelCustomizationDataSetPo.ModelName = _ctx.StringValue("GetCustomizationConfigList.Data["+ i +"].ModelName");
				modelCustomizationDataSetPo.ModelStatus = _ctx.IntegerValue("GetCustomizationConfigList.Data["+ i +"].ModelStatus");
				modelCustomizationDataSetPo.TaskType = _ctx.IntegerValue("GetCustomizationConfigList.Data["+ i +"].TaskType");
				modelCustomizationDataSetPo.CreateTime = _ctx.StringValue("GetCustomizationConfigList.Data["+ i +"].CreateTime");

				getCustomizationConfigListResponse_data.Add(modelCustomizationDataSetPo);
			}
			getCustomizationConfigListResponse.Data = getCustomizationConfigListResponse_data;
        
			return getCustomizationConfigListResponse;
        }
    }
}
