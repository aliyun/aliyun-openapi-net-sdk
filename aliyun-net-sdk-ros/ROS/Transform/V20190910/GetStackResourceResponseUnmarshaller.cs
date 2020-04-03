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
        public static GetStackResourceResponse Unmarshall(UnmarshallerContext context)
        {
			GetStackResourceResponse getStackResourceResponse = new GetStackResourceResponse();

			getStackResourceResponse.HttpResponse = context.HttpResponse;
			getStackResourceResponse.CreateTime = context.StringValue("GetStackResource.CreateTime");
			getStackResourceResponse.Description = context.StringValue("GetStackResource.Description");
			getStackResourceResponse.LogicalResourceId = context.StringValue("GetStackResource.LogicalResourceId");
			getStackResourceResponse.Metadata = context.StringValue("GetStackResource.Metadata");
			getStackResourceResponse.PhysicalResourceId = context.StringValue("GetStackResource.PhysicalResourceId");
			getStackResourceResponse.RequestId = context.StringValue("GetStackResource.RequestId");
			getStackResourceResponse.ResourceType = context.StringValue("GetStackResource.ResourceType");
			getStackResourceResponse.StackId = context.StringValue("GetStackResource.StackId");
			getStackResourceResponse.StackName = context.StringValue("GetStackResource.StackName");
			getStackResourceResponse.Status = context.StringValue("GetStackResource.Status");
			getStackResourceResponse.StatusReason = context.StringValue("GetStackResource.StatusReason");
			getStackResourceResponse.UpdateTime = context.StringValue("GetStackResource.UpdateTime");
			getStackResourceResponse.ResourceDriftStatus = context.StringValue("GetStackResource.ResourceDriftStatus");
			getStackResourceResponse.DriftDetectionTime = context.StringValue("GetStackResource.DriftDetectionTime");

			List<Dictionary<string, string>> getStackResourceResponse_resourceAttributes = new List<Dictionary<string, string>>();
			for (int i = 0; i < context.Length("GetStackResource.ResourceAttributes.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in context.ResponseDictionary){
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
