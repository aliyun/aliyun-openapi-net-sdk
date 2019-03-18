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
using Aliyun.Acs.Ots.Model.V20160620;

namespace Aliyun.Acs.Ots.Transform.V20160620
{
    public class ListClusterTypeResponseUnmarshaller
    {
        public static ListClusterTypeResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterTypeResponse listClusterTypeResponse = new ListClusterTypeResponse();

			listClusterTypeResponse.HttpResponse = context.HttpResponse;
			listClusterTypeResponse.RequestId = context.StringValue("ListClusterType.RequestId");

			List<string> listClusterTypeResponse_clusterTypeInfos = new List<string>();
			for (int i = 0; i < context.Length("ListClusterType.ClusterTypeInfos.Length"); i++) {
				listClusterTypeResponse_clusterTypeInfos.Add(context.StringValue("ListClusterType.ClusterTypeInfos["+ i +"]"));
			}
			listClusterTypeResponse.ClusterTypeInfos = listClusterTypeResponse_clusterTypeInfos;
        
			return listClusterTypeResponse;
        }
    }
}
