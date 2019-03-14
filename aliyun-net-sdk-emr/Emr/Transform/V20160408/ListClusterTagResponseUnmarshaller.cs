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
    public class ListClusterTagResponseUnmarshaller
    {
        public static ListClusterTagResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterTagResponse listClusterTagResponse = new ListClusterTagResponse();

			listClusterTagResponse.HttpResponse = context.HttpResponse;
			listClusterTagResponse.RequestId = context.StringValue("ListClusterTag.RequestId");

			List<ListClusterTagResponse.ListClusterTag_ClusterTag> listClusterTagResponse_clusterTagList = new List<ListClusterTagResponse.ListClusterTag_ClusterTag>();
			for (int i = 0; i < context.Length("ListClusterTag.ClusterTagList.Length"); i++) {
				ListClusterTagResponse.ListClusterTag_ClusterTag clusterTag = new ListClusterTagResponse.ListClusterTag_ClusterTag();
				clusterTag.ClusterId = context.StringValue("ListClusterTag.ClusterTagList["+ i +"].ClusterId");

				List<ListClusterTagResponse.ListClusterTag_ClusterTag.ListClusterTag_TagInfo> clusterTag_tagInfoList = new List<ListClusterTagResponse.ListClusterTag_ClusterTag.ListClusterTag_TagInfo>();
				for (int j = 0; j < context.Length("ListClusterTag.ClusterTagList["+ i +"].TagInfoList.Length"); j++) {
					ListClusterTagResponse.ListClusterTag_ClusterTag.ListClusterTag_TagInfo tagInfo = new ListClusterTagResponse.ListClusterTag_ClusterTag.ListClusterTag_TagInfo();
					tagInfo.TagType = context.StringValue("ListClusterTag.ClusterTagList["+ i +"].TagInfoList["+ j +"].TagType");
					tagInfo.TagValue = context.StringValue("ListClusterTag.ClusterTagList["+ i +"].TagInfoList["+ j +"].TagValue");
					tagInfo.TagKey = context.StringValue("ListClusterTag.ClusterTagList["+ i +"].TagInfoList["+ j +"].TagKey");

					clusterTag_tagInfoList.Add(tagInfo);
				}
				clusterTag.TagInfoList = clusterTag_tagInfoList;

				listClusterTagResponse_clusterTagList.Add(clusterTag);
			}
			listClusterTagResponse.ClusterTagList = listClusterTagResponse_clusterTagList;
        
			return listClusterTagResponse;
        }
    }
}
