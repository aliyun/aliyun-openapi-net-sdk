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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class CreateOpsItemResponseUnmarshaller
    {
        public static CreateOpsItemResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateOpsItemResponse createOpsItemResponse = new CreateOpsItemResponse();

			createOpsItemResponse.HttpResponse = _ctx.HttpResponse;
			createOpsItemResponse.RequestId = _ctx.StringValue("CreateOpsItem.RequestId");

			CreateOpsItemResponse.CreateOpsItem_OpsItem opsItem = new CreateOpsItemResponse.CreateOpsItem_OpsItem();
			opsItem.Tags = _ctx.StringValue("CreateOpsItem.OpsItem.Tags");
			opsItem.UpdateDate = _ctx.StringValue("CreateOpsItem.OpsItem.UpdateDate");
			opsItem.Description = _ctx.StringValue("CreateOpsItem.OpsItem.Description");
			opsItem.OpsItemId = _ctx.StringValue("CreateOpsItem.OpsItem.OpsItemId");
			opsItem.CreateDate = _ctx.StringValue("CreateOpsItem.OpsItem.CreateDate");
			opsItem.Title = _ctx.StringValue("CreateOpsItem.OpsItem.Title");
			opsItem.Status = _ctx.StringValue("CreateOpsItem.OpsItem.Status");
			opsItem.Severity = _ctx.StringValue("CreateOpsItem.OpsItem.Severity");
			opsItem.Category = _ctx.StringValue("CreateOpsItem.OpsItem.Category");
			opsItem.Source = _ctx.StringValue("CreateOpsItem.OpsItem.Source");
			opsItem.Priority = _ctx.IntegerValue("CreateOpsItem.OpsItem.Priority");
			opsItem.Solutions = _ctx.StringValue("CreateOpsItem.OpsItem.Solutions");
			opsItem.Resources = _ctx.StringValue("CreateOpsItem.OpsItem.Resources");
			opsItem.Attributes = _ctx.StringValue("CreateOpsItem.OpsItem.Attributes");
			opsItem.CreatedBy = _ctx.StringValue("CreateOpsItem.OpsItem.CreatedBy");
			opsItem.LastModifiedBy = _ctx.StringValue("CreateOpsItem.OpsItem.LastModifiedBy");
			opsItem.ResourceGroupId = _ctx.StringValue("CreateOpsItem.OpsItem.ResourceGroupId");
			createOpsItemResponse.OpsItem = opsItem;
        
			return createOpsItemResponse;
        }
    }
}
