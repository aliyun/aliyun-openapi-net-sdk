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
    public class ListClusterScriptsResponseUnmarshaller
    {
        public static ListClusterScriptsResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterScriptsResponse listClusterScriptsResponse = new ListClusterScriptsResponse();

			listClusterScriptsResponse.HttpResponse = context.HttpResponse;
			listClusterScriptsResponse.RequestId = context.StringValue("ListClusterScripts.RequestId");

			List<ListClusterScriptsResponse.ListClusterScripts_ClusterScript> listClusterScriptsResponse_clusterScripts = new List<ListClusterScriptsResponse.ListClusterScripts_ClusterScript>();
			for (int i = 0; i < context.Length("ListClusterScripts.ClusterScripts.Length"); i++) {
				ListClusterScriptsResponse.ListClusterScripts_ClusterScript clusterScript = new ListClusterScriptsResponse.ListClusterScripts_ClusterScript();
				clusterScript.Id = context.StringValue("ListClusterScripts.ClusterScripts["+ i +"].Id");
				clusterScript.Name = context.StringValue("ListClusterScripts.ClusterScripts["+ i +"].Name");
				clusterScript.StartTime = context.LongValue("ListClusterScripts.ClusterScripts["+ i +"].StartTime");
				clusterScript.EndTime = context.LongValue("ListClusterScripts.ClusterScripts["+ i +"].EndTime");
				clusterScript.Path = context.StringValue("ListClusterScripts.ClusterScripts["+ i +"].Path");
				clusterScript.Args = context.StringValue("ListClusterScripts.ClusterScripts["+ i +"].Args");
				clusterScript.Status = context.StringValue("ListClusterScripts.ClusterScripts["+ i +"].Status");

				listClusterScriptsResponse_clusterScripts.Add(clusterScript);
			}
			listClusterScriptsResponse.ClusterScripts = listClusterScriptsResponse_clusterScripts;
        
			return listClusterScriptsResponse;
        }
    }
}
