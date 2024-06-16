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
    public class GetOpsItemResponseUnmarshaller
    {
        public static GetOpsItemResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOpsItemResponse getOpsItemResponse = new GetOpsItemResponse();

			getOpsItemResponse.HttpResponse = _ctx.HttpResponse;
			getOpsItemResponse.RequestId = _ctx.StringValue("GetOpsItem.RequestId");

			GetOpsItemResponse.GetOpsItem_OpsItem opsItem = new GetOpsItemResponse.GetOpsItem_OpsItem();
			opsItem.OpsItemId = _ctx.StringValue("GetOpsItem.OpsItem.OpsItemId");
			opsItem.CreateDate = _ctx.StringValue("GetOpsItem.OpsItem.CreateDate");
			opsItem.UpdateDate = _ctx.StringValue("GetOpsItem.OpsItem.UpdateDate");
			opsItem.Title = _ctx.StringValue("GetOpsItem.OpsItem.Title");
			opsItem.Status = _ctx.StringValue("GetOpsItem.OpsItem.Status");
			opsItem.Severity = _ctx.StringValue("GetOpsItem.OpsItem.Severity");
			opsItem.Category = _ctx.StringValue("GetOpsItem.OpsItem.Category");
			opsItem.Source = _ctx.StringValue("GetOpsItem.OpsItem.Source");
			opsItem.Priority = _ctx.IntegerValue("GetOpsItem.OpsItem.Priority");
			opsItem.Tags = _ctx.StringValue("GetOpsItem.OpsItem.Tags");
			opsItem.DedupString = _ctx.StringValue("GetOpsItem.OpsItem.DedupString");
			opsItem.ResourceGroupId = _ctx.StringValue("GetOpsItem.OpsItem.ResourceGroupId");
			opsItem.Description = _ctx.StringValue("GetOpsItem.OpsItem.Description");
			opsItem.CreateBy = _ctx.StringValue("GetOpsItem.OpsItem.CreateBy");
			opsItem.LastModifiedBy = _ctx.StringValue("GetOpsItem.OpsItem.LastModifiedBy");
			opsItem.Attributes = _ctx.StringValue("GetOpsItem.OpsItem.Attributes");

			List<Dictionary<string, string>> opsItem_solutions = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("GetOpsItem.OpsItem.Solutions.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "GetOpsItem.OpsItem.Solutions["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					opsItem_solutions.Add(tmp);
				}
			}
			opsItem.Solutions = opsItem_solutions;

			List<string> opsItem_resources = new List<string>();
			for (int i = 0; i < _ctx.Length("GetOpsItem.OpsItem.Resources.Length"); i++) {
				opsItem_resources.Add(_ctx.StringValue("GetOpsItem.OpsItem.Resources["+ i +"]"));
			}
			opsItem.Resources = opsItem_resources;
			getOpsItemResponse.OpsItem = opsItem;
        
			return getOpsItemResponse;
        }
    }
}
