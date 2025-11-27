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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeSophonCommandsResponseUnmarshaller
    {
        public static DescribeSophonCommandsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSophonCommandsResponse describeSophonCommandsResponse = new DescribeSophonCommandsResponse();

			describeSophonCommandsResponse.HttpResponse = _ctx.HttpResponse;
			describeSophonCommandsResponse.RequestId = _ctx.StringValue("DescribeSophonCommands.RequestId");

			List<DescribeSophonCommandsResponse.DescribeSophonCommands_DataItem> describeSophonCommandsResponse_data = new List<DescribeSophonCommandsResponse.DescribeSophonCommands_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeSophonCommands.Data.Length"); i++) {
				DescribeSophonCommandsResponse.DescribeSophonCommands_DataItem dataItem = new DescribeSophonCommandsResponse.DescribeSophonCommands_DataItem();
				dataItem.Name = _ctx.StringValue("DescribeSophonCommands.Data["+ i +"].Name");
				dataItem.DisplayName = _ctx.StringValue("DescribeSophonCommands.Data["+ i +"].DisplayName");
				dataItem.CommandEntity = _ctx.StringValue("DescribeSophonCommands.Data["+ i +"].CommandEntity");
				dataItem.CommandTag = _ctx.StringValue("DescribeSophonCommands.Data["+ i +"].CommandTag");
				dataItem.Description = _ctx.StringValue("DescribeSophonCommands.Data["+ i +"].Description");
				dataItem.ActionType = _ctx.StringValue("DescribeSophonCommands.Data["+ i +"].ActionType");
				dataItem.TaskConfig = _ctx.StringValue("DescribeSophonCommands.Data["+ i +"].TaskConfig");

				List<DescribeSophonCommandsResponse.DescribeSophonCommands_DataItem.DescribeSophonCommands_ParamConfigItem> dataItem_paramConfig = new List<DescribeSophonCommandsResponse.DescribeSophonCommands_DataItem.DescribeSophonCommands_ParamConfigItem>();
				for (int j = 0; j < _ctx.Length("DescribeSophonCommands.Data["+ i +"].ParamConfig.Length"); j++) {
					DescribeSophonCommandsResponse.DescribeSophonCommands_DataItem.DescribeSophonCommands_ParamConfigItem paramConfigItem = new DescribeSophonCommandsResponse.DescribeSophonCommands_DataItem.DescribeSophonCommands_ParamConfigItem();
					paramConfigItem.Necessary = _ctx.BooleanValue("DescribeSophonCommands.Data["+ i +"].ParamConfig["+ j +"].Necessary");
					paramConfigItem.Field = _ctx.StringValue("DescribeSophonCommands.Data["+ i +"].ParamConfig["+ j +"].Field");
					paramConfigItem._Value = _ctx.StringValue("DescribeSophonCommands.Data["+ i +"].ParamConfig["+ j +"].Value");
					paramConfigItem.CheckField = _ctx.StringValue("DescribeSophonCommands.Data["+ i +"].ParamConfig["+ j +"].CheckField");

					dataItem_paramConfig.Add(paramConfigItem);
				}
				dataItem.ParamConfig = dataItem_paramConfig;

				describeSophonCommandsResponse_data.Add(dataItem);
			}
			describeSophonCommandsResponse.Data = describeSophonCommandsResponse_data;
        
			return describeSophonCommandsResponse;
        }
    }
}
