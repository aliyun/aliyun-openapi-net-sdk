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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeDisposeAndPlaybookResponseUnmarshaller
    {
        public static DescribeDisposeAndPlaybookResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDisposeAndPlaybookResponse describeDisposeAndPlaybookResponse = new DescribeDisposeAndPlaybookResponse();

			describeDisposeAndPlaybookResponse.HttpResponse = _ctx.HttpResponse;
			describeDisposeAndPlaybookResponse.Success = _ctx.BooleanValue("DescribeDisposeAndPlaybook.Success");
			describeDisposeAndPlaybookResponse.Code = _ctx.IntegerValue("DescribeDisposeAndPlaybook.Code");
			describeDisposeAndPlaybookResponse.Message = _ctx.StringValue("DescribeDisposeAndPlaybook.Message");
			describeDisposeAndPlaybookResponse.RequestId = _ctx.StringValue("DescribeDisposeAndPlaybook.RequestId");

			DescribeDisposeAndPlaybookResponse.DescribeDisposeAndPlaybook_Data data = new DescribeDisposeAndPlaybookResponse.DescribeDisposeAndPlaybook_Data();

			DescribeDisposeAndPlaybookResponse.DescribeDisposeAndPlaybook_Data.DescribeDisposeAndPlaybook_PageInfo pageInfo = new DescribeDisposeAndPlaybookResponse.DescribeDisposeAndPlaybook_Data.DescribeDisposeAndPlaybook_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeDisposeAndPlaybook.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeDisposeAndPlaybook.Data.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.LongValue("DescribeDisposeAndPlaybook.Data.PageInfo.TotalCount");
			data.PageInfo = pageInfo;

			List<DescribeDisposeAndPlaybookResponse.DescribeDisposeAndPlaybook_Data.DescribeDisposeAndPlaybook_ResponseDataItem> data_responseData = new List<DescribeDisposeAndPlaybookResponse.DescribeDisposeAndPlaybook_Data.DescribeDisposeAndPlaybook_ResponseDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeDisposeAndPlaybook.Data.ResponseData.Length"); i++) {
				DescribeDisposeAndPlaybookResponse.DescribeDisposeAndPlaybook_Data.DescribeDisposeAndPlaybook_ResponseDataItem responseDataItem = new DescribeDisposeAndPlaybookResponse.DescribeDisposeAndPlaybook_Data.DescribeDisposeAndPlaybook_ResponseDataItem();
				responseDataItem.EntityId = _ctx.LongValue("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].EntityId");
				responseDataItem.OpcodeMap = _ctx.StringValue("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].OpcodeMap");
				responseDataItem.EntityInfo = _ctx.StringValue("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].EntityInfo");
				responseDataItem.Dispose = _ctx.StringValue("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].Dispose");
				responseDataItem.AlertNum = _ctx.IntegerValue("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].AlertNum");

				List<string> responseDataItem_opcodeSet = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].OpcodeSet.Length"); j++) {
					responseDataItem_opcodeSet.Add(_ctx.StringValue("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].OpcodeSet["+ j +"]"));
				}
				responseDataItem.OpcodeSet = responseDataItem_opcodeSet;

				List<string> responseDataItem_scope = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].Scope.Length"); j++) {
					responseDataItem_scope.Add(_ctx.StringValue("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].Scope["+ j +"]"));
				}
				responseDataItem.Scope = responseDataItem_scope;

				List<DescribeDisposeAndPlaybookResponse.DescribeDisposeAndPlaybook_Data.DescribeDisposeAndPlaybook_ResponseDataItem.DescribeDisposeAndPlaybook_PlaybookListItem> responseDataItem_playbookList = new List<DescribeDisposeAndPlaybookResponse.DescribeDisposeAndPlaybook_Data.DescribeDisposeAndPlaybook_ResponseDataItem.DescribeDisposeAndPlaybook_PlaybookListItem>();
				for (int j = 0; j < _ctx.Length("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].PlaybookList.Length"); j++) {
					DescribeDisposeAndPlaybookResponse.DescribeDisposeAndPlaybook_Data.DescribeDisposeAndPlaybook_ResponseDataItem.DescribeDisposeAndPlaybook_PlaybookListItem playbookListItem = new DescribeDisposeAndPlaybookResponse.DescribeDisposeAndPlaybook_Data.DescribeDisposeAndPlaybook_ResponseDataItem.DescribeDisposeAndPlaybook_PlaybookListItem();
					playbookListItem.OpCode = _ctx.StringValue("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].PlaybookList["+ j +"].OpCode");
					playbookListItem.OpLevel = _ctx.StringValue("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].PlaybookList["+ j +"].OpLevel");
					playbookListItem.Description = _ctx.StringValue("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].PlaybookList["+ j +"].Description");
					playbookListItem.DisplayName = _ctx.StringValue("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].PlaybookList["+ j +"].DisplayName");
					playbookListItem.TaskConfig = _ctx.StringValue("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].PlaybookList["+ j +"].TaskConfig");
					playbookListItem.Name = _ctx.StringValue("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].PlaybookList["+ j +"].Name");
					playbookListItem.WafPlaybook = _ctx.BooleanValue("DescribeDisposeAndPlaybook.Data.ResponseData["+ i +"].PlaybookList["+ j +"].WafPlaybook");

					responseDataItem_playbookList.Add(playbookListItem);
				}
				responseDataItem.PlaybookList = responseDataItem_playbookList;

				data_responseData.Add(responseDataItem);
			}
			data.ResponseData = data_responseData;
			describeDisposeAndPlaybookResponse.Data = data;
        
			return describeDisposeAndPlaybookResponse;
        }
    }
}
