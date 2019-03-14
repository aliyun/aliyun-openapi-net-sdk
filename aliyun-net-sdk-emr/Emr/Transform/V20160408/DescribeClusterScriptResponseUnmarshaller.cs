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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeClusterScriptResponseUnmarshaller
    {
        public static DescribeClusterScriptResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeClusterScriptResponse describeClusterScriptResponse = new DescribeClusterScriptResponse();

			describeClusterScriptResponse.HttpResponse = context.HttpResponse;
			describeClusterScriptResponse.RequestId = context.StringValue("DescribeClusterScript.RequestId");

			List<DescribeClusterScriptResponse.DescribeClusterScript_ScriptNodeInstance> describeClusterScriptResponse_scriptNodeInstances = new List<DescribeClusterScriptResponse.DescribeClusterScript_ScriptNodeInstance>();
			for (int i = 0; i < context.Length("DescribeClusterScript.ScriptNodeInstances.Length"); i++) {
				DescribeClusterScriptResponse.DescribeClusterScript_ScriptNodeInstance scriptNodeInstance = new DescribeClusterScriptResponse.DescribeClusterScript_ScriptNodeInstance();
				scriptNodeInstance.NodeId = context.StringValue("DescribeClusterScript.ScriptNodeInstances["+ i +"].NodeId");
				scriptNodeInstance.NodeIp = context.StringValue("DescribeClusterScript.ScriptNodeInstances["+ i +"].NodeIp");
				scriptNodeInstance.StartTime = context.LongValue("DescribeClusterScript.ScriptNodeInstances["+ i +"].StartTime");
				scriptNodeInstance.EndTime = context.LongValue("DescribeClusterScript.ScriptNodeInstances["+ i +"].EndTime");
				scriptNodeInstance.Status = context.StringValue("DescribeClusterScript.ScriptNodeInstances["+ i +"].Status");

				describeClusterScriptResponse_scriptNodeInstances.Add(scriptNodeInstance);
			}
			describeClusterScriptResponse.ScriptNodeInstances = describeClusterScriptResponse_scriptNodeInstances;
        
			return describeClusterScriptResponse;
        }
    }
}
