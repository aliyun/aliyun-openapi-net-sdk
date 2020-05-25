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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class GetFaceOptionsResponseUnmarshaller
    {
        public static GetFaceOptionsResponse Unmarshall(UnmarshallerContext context)
        {
			GetFaceOptionsResponse getFaceOptionsResponse = new GetFaceOptionsResponse();

			getFaceOptionsResponse.HttpResponse = context.HttpResponse;
			getFaceOptionsResponse.Code = context.StringValue("GetFaceOptions.Code");
			getFaceOptionsResponse.Message = context.StringValue("GetFaceOptions.Message");
			getFaceOptionsResponse.RequestId = context.StringValue("GetFaceOptions.RequestId");

			List<GetFaceOptionsResponse.GetFaceOptions_DataItem> getFaceOptionsResponse_data = new List<GetFaceOptionsResponse.GetFaceOptions_DataItem>();
			for (int i = 0; i < context.Length("GetFaceOptions.Data.Length"); i++) {
				GetFaceOptionsResponse.GetFaceOptions_DataItem dataItem = new GetFaceOptionsResponse.GetFaceOptions_DataItem();
				dataItem.Key = context.StringValue("GetFaceOptions.Data["+ i +"].Key");
				dataItem.Name = context.StringValue("GetFaceOptions.Data["+ i +"].Name");

				List<GetFaceOptionsResponse.GetFaceOptions_DataItem.GetFaceOptions_OptionListItem> dataItem_optionList = new List<GetFaceOptionsResponse.GetFaceOptions_DataItem.GetFaceOptions_OptionListItem>();
				for (int j = 0; j < context.Length("GetFaceOptions.Data["+ i +"].OptionList.Length"); j++) {
					GetFaceOptionsResponse.GetFaceOptions_DataItem.GetFaceOptions_OptionListItem optionListItem = new GetFaceOptionsResponse.GetFaceOptions_DataItem.GetFaceOptions_OptionListItem();
					optionListItem.Key = context.StringValue("GetFaceOptions.Data["+ i +"].OptionList["+ j +"].Key");
					optionListItem.Name = context.StringValue("GetFaceOptions.Data["+ i +"].OptionList["+ j +"].Name");

					dataItem_optionList.Add(optionListItem);
				}
				dataItem.OptionList = dataItem_optionList;

				getFaceOptionsResponse_data.Add(dataItem);
			}
			getFaceOptionsResponse.Data = getFaceOptionsResponse_data;
        
			return getFaceOptionsResponse;
        }
    }
}
