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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeTraceInfoNodeListResponseUnmarshaller
    {
        public static DescribeTraceInfoNodeListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTraceInfoNodeListResponse describeTraceInfoNodeListResponse = new DescribeTraceInfoNodeListResponse();

			describeTraceInfoNodeListResponse.HttpResponse = context.HttpResponse;
			describeTraceInfoNodeListResponse.RequestId = context.StringValue("DescribeTraceInfoNodeList.RequestId");

			DescribeTraceInfoNodeListResponse.DescribeTraceInfoNodeList_NodeListInfo nodeListInfo = new DescribeTraceInfoNodeListResponse.DescribeTraceInfoNodeList_NodeListInfo();

			List<string> nodeListInfo_entityTypeList = new List<string>();
			for (int i = 0; i < context.Length("DescribeTraceInfoNodeList.NodeListInfo.EntityTypeList.Length"); i++) {
				nodeListInfo_entityTypeList.Add(context.StringValue("DescribeTraceInfoNodeList.NodeListInfo.EntityTypeList["+ i +"]"));
			}
			nodeListInfo.EntityTypeList = nodeListInfo_entityTypeList;

			List<DescribeTraceInfoNodeListResponse.DescribeTraceInfoNodeList_NodeListInfo.DescribeTraceInfoNodeList_Edge> nodeListInfo_edgeList = new List<DescribeTraceInfoNodeListResponse.DescribeTraceInfoNodeList_NodeListInfo.DescribeTraceInfoNodeList_Edge>();
			for (int i = 0; i < context.Length("DescribeTraceInfoNodeList.NodeListInfo.EdgeList.Length"); i++) {
				DescribeTraceInfoNodeListResponse.DescribeTraceInfoNodeList_NodeListInfo.DescribeTraceInfoNodeList_Edge edge = new DescribeTraceInfoNodeListResponse.DescribeTraceInfoNodeList_NodeListInfo.DescribeTraceInfoNodeList_Edge();
				edge.EndId = context.StringValue("DescribeTraceInfoNodeList.NodeListInfo.EdgeList["+ i +"].EndId");
				edge.StartId = context.StringValue("DescribeTraceInfoNodeList.NodeListInfo.EdgeList["+ i +"].StartId");
				edge.Time = context.StringValue("DescribeTraceInfoNodeList.NodeListInfo.EdgeList["+ i +"].Time");

				nodeListInfo_edgeList.Add(edge);
			}
			nodeListInfo.EdgeList = nodeListInfo_edgeList;

			List<DescribeTraceInfoNodeListResponse.DescribeTraceInfoNodeList_NodeListInfo.DescribeTraceInfoNodeList_Vertex> nodeListInfo_vertexList = new List<DescribeTraceInfoNodeListResponse.DescribeTraceInfoNodeList_NodeListInfo.DescribeTraceInfoNodeList_Vertex>();
			for (int i = 0; i < context.Length("DescribeTraceInfoNodeList.NodeListInfo.VertexList.Length"); i++) {
				DescribeTraceInfoNodeListResponse.DescribeTraceInfoNodeList_NodeListInfo.DescribeTraceInfoNodeList_Vertex vertex = new DescribeTraceInfoNodeListResponse.DescribeTraceInfoNodeList_NodeListInfo.DescribeTraceInfoNodeList_Vertex();
				vertex.Name = context.StringValue("DescribeTraceInfoNodeList.NodeListInfo.VertexList["+ i +"].Name");
				vertex.Id = context.StringValue("DescribeTraceInfoNodeList.NodeListInfo.VertexList["+ i +"].Id");
				vertex.Time = context.StringValue("DescribeTraceInfoNodeList.NodeListInfo.VertexList["+ i +"].Time");

				List<string> vertex_neighborList = new List<string>();
				for (int j = 0; j < context.Length("DescribeTraceInfoNodeList.NodeListInfo.VertexList["+ i +"].NeighborList.Length"); j++) {
					vertex_neighborList.Add(context.StringValue("DescribeTraceInfoNodeList.NodeListInfo.VertexList["+ i +"].NeighborList["+ j +"]"));
				}
				vertex.NeighborList = vertex_neighborList;

				nodeListInfo_vertexList.Add(vertex);
			}
			nodeListInfo.VertexList = nodeListInfo_vertexList;
			describeTraceInfoNodeListResponse.NodeListInfo = nodeListInfo;
        
			return describeTraceInfoNodeListResponse;
        }
    }
}
