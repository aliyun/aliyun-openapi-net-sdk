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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class GetStackResourceResponseUnmarshaller
    {
        public static GetStackResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetStackResourceResponse getStackResourceResponse = new GetStackResourceResponse();

			getStackResourceResponse.HttpResponse = _ctx.HttpResponse;
			getStackResourceResponse.CreateTime = _ctx.StringValue("GetStackResource.CreateTime");
			getStackResourceResponse.Description = _ctx.StringValue("GetStackResource.Description");
			getStackResourceResponse.LogicalResourceId = _ctx.StringValue("GetStackResource.LogicalResourceId");
			getStackResourceResponse.Metadata = _ctx.StringValue("GetStackResource.Metadata");
			getStackResourceResponse.PhysicalResourceId = _ctx.StringValue("GetStackResource.PhysicalResourceId");
			getStackResourceResponse.RequestId = _ctx.StringValue("GetStackResource.RequestId");
			getStackResourceResponse.ResourceType = _ctx.StringValue("GetStackResource.ResourceType");
			getStackResourceResponse.StackId = _ctx.StringValue("GetStackResource.StackId");
			getStackResourceResponse.StackName = _ctx.StringValue("GetStackResource.StackName");
			getStackResourceResponse.Status = _ctx.StringValue("GetStackResource.Status");
			getStackResourceResponse.StatusReason = _ctx.StringValue("GetStackResource.StatusReason");
			getStackResourceResponse.UpdateTime = _ctx.StringValue("GetStackResource.UpdateTime");
			getStackResourceResponse.ResourceDriftStatus = _ctx.StringValue("GetStackResource.ResourceDriftStatus");
			getStackResourceResponse.DriftDetectionTime = _ctx.StringValue("GetStackResource.DriftDetectionTime");

			List<Dictionary<string, string>> getStackResourceResponse_resourceAttributes = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("GetStackResource.ResourceAttributes.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "GetStackResource.ResourceAttributes["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					getStackResourceResponse_resourceAttributes.Add(tmp);
				}
			}
			getStackResourceResponse.ResourceAttributes = getStackResourceResponse_resourceAttributes;
        
			return getStackResourceResponse;
        }
    }
}
