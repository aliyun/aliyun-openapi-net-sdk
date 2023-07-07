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
    public class UpdateOpsItemResponseUnmarshaller
    {
        public static UpdateOpsItemResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateOpsItemResponse updateOpsItemResponse = new UpdateOpsItemResponse();

			updateOpsItemResponse.HttpResponse = _ctx.HttpResponse;
			updateOpsItemResponse.RequestId = _ctx.StringValue("UpdateOpsItem.RequestId");

			UpdateOpsItemResponse.UpdateOpsItem_OpsItem opsItem = new UpdateOpsItemResponse.UpdateOpsItem_OpsItem();
			opsItem.Tags = _ctx.StringValue("UpdateOpsItem.OpsItem.Tags");
			opsItem.UpdateDate = _ctx.StringValue("UpdateOpsItem.OpsItem.UpdateDate");
			opsItem.Description = _ctx.StringValue("UpdateOpsItem.OpsItem.Description");
			opsItem.OpsItemId = _ctx.StringValue("UpdateOpsItem.OpsItem.OpsItemId");
			opsItem.CreateDate = _ctx.StringValue("UpdateOpsItem.OpsItem.CreateDate");
			opsItem.Title = _ctx.StringValue("UpdateOpsItem.OpsItem.Title");
			opsItem.Status = _ctx.StringValue("UpdateOpsItem.OpsItem.Status");
			opsItem.Severity = _ctx.StringValue("UpdateOpsItem.OpsItem.Severity");
			opsItem.Category = _ctx.StringValue("UpdateOpsItem.OpsItem.Category");
			opsItem.Source = _ctx.StringValue("UpdateOpsItem.OpsItem.Source");
			opsItem.Priority = _ctx.IntegerValue("UpdateOpsItem.OpsItem.Priority");
			opsItem.Attributes = _ctx.StringValue("UpdateOpsItem.OpsItem.Attributes");
			opsItem.CreatedBy = _ctx.StringValue("UpdateOpsItem.OpsItem.CreatedBy");
			opsItem.LastModifiedBy = _ctx.StringValue("UpdateOpsItem.OpsItem.LastModifiedBy");
			opsItem.ResourceGroupId = _ctx.StringValue("UpdateOpsItem.OpsItem.ResourceGroupId");

			List<string> opsItem_solutions = new List<string>();
			for (int i = 0; i < _ctx.Length("UpdateOpsItem.OpsItem.Solutions.Length"); i++) {
				opsItem_solutions.Add(_ctx.StringValue("UpdateOpsItem.OpsItem.Solutions["+ i +"]"));
			}
			opsItem.Solutions = opsItem_solutions;

			List<string> opsItem_resources = new List<string>();
			for (int i = 0; i < _ctx.Length("UpdateOpsItem.OpsItem.Resources.Length"); i++) {
				opsItem_resources.Add(_ctx.StringValue("UpdateOpsItem.OpsItem.Resources["+ i +"]"));
			}
			opsItem.Resources = opsItem_resources;
			updateOpsItemResponse.OpsItem = opsItem;
        
			return updateOpsItemResponse;
        }
    }
}
