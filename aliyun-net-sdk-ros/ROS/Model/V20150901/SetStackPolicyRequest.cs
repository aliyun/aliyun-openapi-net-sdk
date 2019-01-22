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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.ROS.Transform;
using Aliyun.Acs.ROS.Transform.V20150901;
using System.Collections.Generic;

namespace Aliyun.Acs.ROS.Model.V20150901
{
    public class SetStackPolicyRequest : RoaAcsRequest<SetStackPolicyResponse>
    {
        public SetStackPolicyRequest()
            : base("ROS", "2015-09-01", "SetStackPolicy")
        {
			UriPattern = "/stacks/[StackName]/[StackId]/policy";
			Method = MethodType.POST;
        }

		private string stackId;

		private string stackName;

		public string StackId
		{
			get
			{
				return stackId;
			}
			set	
			{
				stackId = value;
				DictionaryUtil.Add(PathParameters, "StackId", value);
			}
		}

		public string StackName
		{
			get
			{
				return stackName;
			}
			set	
			{
				stackName = value;
				DictionaryUtil.Add(PathParameters, "StackName", value);
			}
		}

        public override SetStackPolicyResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetStackPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}