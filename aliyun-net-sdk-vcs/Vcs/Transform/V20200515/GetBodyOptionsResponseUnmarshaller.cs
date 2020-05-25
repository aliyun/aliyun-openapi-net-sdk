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
    public class GetBodyOptionsResponseUnmarshaller
    {
        public static GetBodyOptionsResponse Unmarshall(UnmarshallerContext context)
        {
			GetBodyOptionsResponse getBodyOptionsResponse = new GetBodyOptionsResponse();

			getBodyOptionsResponse.HttpResponse = context.HttpResponse;
			getBodyOptionsResponse.Code = context.StringValue("GetBodyOptions.Code");
			getBodyOptionsResponse.Message = context.StringValue("GetBodyOptions.Message");
			getBodyOptionsResponse.RequestId = context.StringValue("GetBodyOptions.RequestId");

			List<GetBodyOptionsResponse.GetBodyOptions_DataItem> getBodyOptionsResponse_data = new List<GetBodyOptionsResponse.GetBodyOptions_DataItem>();
			for (int i = 0; i < context.Length("GetBodyOptions.Data.Length"); i++) {
				GetBodyOptionsResponse.GetBodyOptions_DataItem dataItem = new GetBodyOptionsResponse.GetBodyOptions_DataItem();
				dataItem.Key = context.StringValue("GetBodyOptions.Data["+ i +"].Key");
				dataItem.Name = context.StringValue("GetBodyOptions.Data["+ i +"].Name");

				List<GetBodyOptionsResponse.GetBodyOptions_DataItem.GetBodyOptions_OptionListItem> dataItem_optionList = new List<GetBodyOptionsResponse.GetBodyOptions_DataItem.GetBodyOptions_OptionListItem>();
				for (int j = 0; j < context.Length("GetBodyOptions.Data["+ i +"].OptionList.Length"); j++) {
					GetBodyOptionsResponse.GetBodyOptions_DataItem.GetBodyOptions_OptionListItem optionListItem = new GetBodyOptionsResponse.GetBodyOptions_DataItem.GetBodyOptions_OptionListItem();
					optionListItem.Key = context.StringValue("GetBodyOptions.Data["+ i +"].OptionList["+ j +"].Key");
					optionListItem.Name = context.StringValue("GetBodyOptions.Data["+ i +"].OptionList["+ j +"].Name");

					dataItem_optionList.Add(optionListItem);
				}
				dataItem.OptionList = dataItem_optionList;

				getBodyOptionsResponse_data.Add(dataItem);
			}
			getBodyOptionsResponse.Data = getBodyOptionsResponse_data;
        
			return getBodyOptionsResponse;
        }
    }
}
