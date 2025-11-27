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
using Aliyun.Acs.WebsiteBuild.Model.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Transform.V20250429
{
    public class ListAppDomainRedirectRecordsResponseUnmarshaller
    {
        public static ListAppDomainRedirectRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppDomainRedirectRecordsResponse listAppDomainRedirectRecordsResponse = new ListAppDomainRedirectRecordsResponse();

			listAppDomainRedirectRecordsResponse.HttpResponse = _ctx.HttpResponse;
			listAppDomainRedirectRecordsResponse.RequestId = _ctx.StringValue("ListAppDomainRedirectRecords.RequestId");
			listAppDomainRedirectRecordsResponse.DynamicCode = _ctx.StringValue("ListAppDomainRedirectRecords.DynamicCode");
			listAppDomainRedirectRecordsResponse.DynamicMessage = _ctx.StringValue("ListAppDomainRedirectRecords.DynamicMessage");
			listAppDomainRedirectRecordsResponse.Synchro = _ctx.BooleanValue("ListAppDomainRedirectRecords.Synchro");
			listAppDomainRedirectRecordsResponse.AccessDeniedDetail = _ctx.StringValue("ListAppDomainRedirectRecords.AccessDeniedDetail");
			listAppDomainRedirectRecordsResponse.RootErrorMsg = _ctx.StringValue("ListAppDomainRedirectRecords.RootErrorMsg");
			listAppDomainRedirectRecordsResponse.RootErrorCode = _ctx.StringValue("ListAppDomainRedirectRecords.RootErrorCode");
			listAppDomainRedirectRecordsResponse.AllowRetry = _ctx.BooleanValue("ListAppDomainRedirectRecords.AllowRetry");
			listAppDomainRedirectRecordsResponse.AppName = _ctx.StringValue("ListAppDomainRedirectRecords.AppName");
			listAppDomainRedirectRecordsResponse.MaxResults = _ctx.IntegerValue("ListAppDomainRedirectRecords.MaxResults");
			listAppDomainRedirectRecordsResponse.NextToken = _ctx.StringValue("ListAppDomainRedirectRecords.NextToken");

			List<string> listAppDomainRedirectRecordsResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("ListAppDomainRedirectRecords.ErrorArgs.Length"); i++) {
				listAppDomainRedirectRecordsResponse_errorArgs.Add(_ctx.StringValue("ListAppDomainRedirectRecords.ErrorArgs["+ i +"]"));
			}
			listAppDomainRedirectRecordsResponse.ErrorArgs = listAppDomainRedirectRecordsResponse_errorArgs;

			ListAppDomainRedirectRecordsResponse.ListAppDomainRedirectRecords_Module module = new ListAppDomainRedirectRecordsResponse.ListAppDomainRedirectRecords_Module();
			module.TotalItemNum = _ctx.IntegerValue("ListAppDomainRedirectRecords.Module.TotalItemNum");
			module.CurrentPageNum = _ctx.IntegerValue("ListAppDomainRedirectRecords.Module.CurrentPageNum");
			module.PageSize = _ctx.IntegerValue("ListAppDomainRedirectRecords.Module.PageSize");
			module.TotalPageNum = _ctx.IntegerValue("ListAppDomainRedirectRecords.Module.TotalPageNum");
			module.PrePage = _ctx.BooleanValue("ListAppDomainRedirectRecords.Module.PrePage");
			module.NextPage = _ctx.BooleanValue("ListAppDomainRedirectRecords.Module.NextPage");
			module.ResultLimit = _ctx.BooleanValue("ListAppDomainRedirectRecords.Module.ResultLimit");

			ListAppDomainRedirectRecordsResponse.ListAppDomainRedirectRecords_Module.ListAppDomainRedirectRecords_Next next = new ListAppDomainRedirectRecordsResponse.ListAppDomainRedirectRecords_Module.ListAppDomainRedirectRecords_Next();
			next.RecordId = _ctx.StringValue("ListAppDomainRedirectRecords.Module.Next.RecordId");
			next.SourceDomain = _ctx.StringValue("ListAppDomainRedirectRecords.Module.Next.SourceDomain");
			next.TargetDomain = _ctx.StringValue("ListAppDomainRedirectRecords.Module.Next.TargetDomain");
			module.Next = next;

			List<ListAppDomainRedirectRecordsResponse.ListAppDomainRedirectRecords_Module.ListAppDomainRedirectRecords_DataItem> module_data = new List<ListAppDomainRedirectRecordsResponse.ListAppDomainRedirectRecords_Module.ListAppDomainRedirectRecords_DataItem>();
			for (int i = 0; i < _ctx.Length("ListAppDomainRedirectRecords.Module.Data.Length"); i++) {
				ListAppDomainRedirectRecordsResponse.ListAppDomainRedirectRecords_Module.ListAppDomainRedirectRecords_DataItem dataItem = new ListAppDomainRedirectRecordsResponse.ListAppDomainRedirectRecords_Module.ListAppDomainRedirectRecords_DataItem();
				dataItem.RecordId = _ctx.StringValue("ListAppDomainRedirectRecords.Module.Data["+ i +"].RecordId");
				dataItem.SourceDomain = _ctx.StringValue("ListAppDomainRedirectRecords.Module.Data["+ i +"].SourceDomain");
				dataItem.TargetDomain = _ctx.StringValue("ListAppDomainRedirectRecords.Module.Data["+ i +"].TargetDomain");

				module_data.Add(dataItem);
			}
			module.Data = module_data;
			listAppDomainRedirectRecordsResponse.Module = module;
        
			return listAppDomainRedirectRecordsResponse;
        }
    }
}
