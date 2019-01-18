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
using Aliyun.Acs.rtc.Model.V20180111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class GetTaskParamResponseUnmarshaller
    {
        public static GetTaskParamResponse Unmarshall(UnmarshallerContext context)
        {
			GetTaskParamResponse getTaskParamResponse = new GetTaskParamResponse();

			getTaskParamResponse.HttpResponse = context.HttpResponse;
			getTaskParamResponse.RequestId = context.StringValue("GetTaskParam.RequestId");
			getTaskParamResponse.ChannelId = context.StringValue("GetTaskParam.ChannelId");
			getTaskParamResponse.TemplateId = context.LongValue("GetTaskParam.TemplateId");

			List<GetTaskParamResponse.GetTaskParam_MixPaneItem> getTaskParamResponse_mixPane = new List<GetTaskParamResponse.GetTaskParam_MixPaneItem>();
			for (int i = 0; i < context.Length("GetTaskParam.MixPane.Length"); i++) {
				GetTaskParamResponse.GetTaskParam_MixPaneItem mixPaneItem = new GetTaskParamResponse.GetTaskParam_MixPaneItem();
				mixPaneItem.PaneId = context.IntegerValue("GetTaskParam.MixPane["+ i +"].PaneId");
				mixPaneItem.UserId = context.StringValue("GetTaskParam.MixPane["+ i +"].UserId");
				mixPaneItem.SourceType = context.StringValue("GetTaskParam.MixPane["+ i +"].SourceType");

				getTaskParamResponse_mixPane.Add(mixPaneItem);
			}
			getTaskParamResponse.MixPane = getTaskParamResponse_mixPane;
        
			return getTaskParamResponse;
        }
    }
}