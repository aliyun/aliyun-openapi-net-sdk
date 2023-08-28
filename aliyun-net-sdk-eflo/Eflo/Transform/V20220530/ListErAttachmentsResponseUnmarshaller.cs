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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class ListErAttachmentsResponseUnmarshaller
    {
        public static ListErAttachmentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListErAttachmentsResponse listErAttachmentsResponse = new ListErAttachmentsResponse();

			listErAttachmentsResponse.HttpResponse = _ctx.HttpResponse;
			listErAttachmentsResponse.Code = _ctx.IntegerValue("ListErAttachments.Code");
			listErAttachmentsResponse.Message = _ctx.StringValue("ListErAttachments.Message");
			listErAttachmentsResponse.RequestId = _ctx.StringValue("ListErAttachments.RequestId");

			ListErAttachmentsResponse.ListErAttachments_Content content = new ListErAttachmentsResponse.ListErAttachments_Content();
			content.Total = _ctx.LongValue("ListErAttachments.Content.Total");

			List<ListErAttachmentsResponse.ListErAttachments_Content.ListErAttachments_DataItem> content_data = new List<ListErAttachmentsResponse.ListErAttachments_Content.ListErAttachments_DataItem>();
			for (int i = 0; i < _ctx.Length("ListErAttachments.Content.Data.Length"); i++) {
				ListErAttachmentsResponse.ListErAttachments_Content.ListErAttachments_DataItem dataItem = new ListErAttachmentsResponse.ListErAttachments_Content.ListErAttachments_DataItem();
				dataItem.CreateTime = _ctx.StringValue("ListErAttachments.Content.Data["+ i +"].CreateTime");
				dataItem.GmtModified = _ctx.StringValue("ListErAttachments.Content.Data["+ i +"].GmtModified");
				dataItem.Message = _ctx.StringValue("ListErAttachments.Content.Data["+ i +"].Message");
				dataItem.Status = _ctx.StringValue("ListErAttachments.Content.Data["+ i +"].Status");
				dataItem.RegionId = _ctx.StringValue("ListErAttachments.Content.Data["+ i +"].RegionId");
				dataItem.TenantId = _ctx.StringValue("ListErAttachments.Content.Data["+ i +"].TenantId");
				dataItem.ErAttachmentName = _ctx.StringValue("ListErAttachments.Content.Data["+ i +"].ErAttachmentName");
				dataItem.ErAttachmentId = _ctx.StringValue("ListErAttachments.Content.Data["+ i +"].ErAttachmentId");
				dataItem.ErId = _ctx.StringValue("ListErAttachments.Content.Data["+ i +"].ErId");
				dataItem.InstanceType = _ctx.StringValue("ListErAttachments.Content.Data["+ i +"].InstanceType");
				dataItem.InstanceId = _ctx.StringValue("ListErAttachments.Content.Data["+ i +"].InstanceId");
				dataItem.InstanceName = _ctx.StringValue("ListErAttachments.Content.Data["+ i +"].InstanceName");
				dataItem.AutoReceiveAllRoute = _ctx.BooleanValue("ListErAttachments.Content.Data["+ i +"].AutoReceiveAllRoute");
				dataItem.Across = _ctx.BooleanValue("ListErAttachments.Content.Data["+ i +"].Across");
				dataItem.ResourceTenantId = _ctx.StringValue("ListErAttachments.Content.Data["+ i +"].ResourceTenantId");

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listErAttachmentsResponse.Content = content;
        
			return listErAttachmentsResponse;
        }
    }
}
