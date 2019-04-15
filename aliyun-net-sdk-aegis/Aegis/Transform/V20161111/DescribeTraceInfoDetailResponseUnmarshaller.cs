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
    public class DescribeTraceInfoDetailResponseUnmarshaller
    {
        public static DescribeTraceInfoDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTraceInfoDetailResponse describeTraceInfoDetailResponse = new DescribeTraceInfoDetailResponse();

			describeTraceInfoDetailResponse.HttpResponse = context.HttpResponse;
			describeTraceInfoDetailResponse.RequestId = context.StringValue("DescribeTraceInfoDetail.RequestId");
			describeTraceInfoDetailResponse.Success = context.BooleanValue("DescribeTraceInfoDetail.Success");

			DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail traceInfoDetail = new DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail();

			List<DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_Edge> traceInfoDetail_edgeList = new List<DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_Edge>();
			for (int i = 0; i < context.Length("DescribeTraceInfoDetail.TraceInfoDetail.EdgeList.Length"); i++) {
				DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_Edge edge = new DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_Edge();
				edge.EndId = context.StringValue("DescribeTraceInfoDetail.TraceInfoDetail.EdgeList["+ i +"].EndId");
				edge.StartId = context.StringValue("DescribeTraceInfoDetail.TraceInfoDetail.EdgeList["+ i +"].StartId");
				edge.Count = context.IntegerValue("DescribeTraceInfoDetail.TraceInfoDetail.EdgeList["+ i +"].Count");
				edge.Time = context.StringValue("DescribeTraceInfoDetail.TraceInfoDetail.EdgeList["+ i +"].Time");

				traceInfoDetail_edgeList.Add(edge);
			}
			traceInfoDetail.EdgeList = traceInfoDetail_edgeList;

			List<DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_Vertex> traceInfoDetail_vertexList = new List<DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_Vertex>();
			for (int i = 0; i < context.Length("DescribeTraceInfoDetail.TraceInfoDetail.VertexList.Length"); i++) {
				DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_Vertex vertex = new DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_Vertex();
				vertex.Name = context.StringValue("DescribeTraceInfoDetail.TraceInfoDetail.VertexList["+ i +"].Name");
				vertex.Count = context.IntegerValue("DescribeTraceInfoDetail.TraceInfoDetail.VertexList["+ i +"].Count");
				vertex.Id = context.StringValue("DescribeTraceInfoDetail.TraceInfoDetail.VertexList["+ i +"].Id");
				vertex.Time = context.StringValue("DescribeTraceInfoDetail.TraceInfoDetail.VertexList["+ i +"].Time");
				vertex.Type = context.StringValue("DescribeTraceInfoDetail.TraceInfoDetail.VertexList["+ i +"].Type");

				List<DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_Vertex.DescribeTraceInfoDetail_Neighbor> vertex_neighborList = new List<DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_Vertex.DescribeTraceInfoDetail_Neighbor>();
				for (int j = 0; j < context.Length("DescribeTraceInfoDetail.TraceInfoDetail.VertexList["+ i +"].NeighborList.Length"); j++) {
					DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_Vertex.DescribeTraceInfoDetail_Neighbor neighbor = new DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_Vertex.DescribeTraceInfoDetail_Neighbor();
					neighbor.HasMore = context.BooleanValue("DescribeTraceInfoDetail.TraceInfoDetail.VertexList["+ i +"].NeighborList["+ j +"].HasMore");
					neighbor.Count = context.IntegerValue("DescribeTraceInfoDetail.TraceInfoDetail.VertexList["+ i +"].NeighborList["+ j +"].Count");
					neighbor.Type = context.StringValue("DescribeTraceInfoDetail.TraceInfoDetail.VertexList["+ i +"].NeighborList["+ j +"].Type");

					vertex_neighborList.Add(neighbor);
				}
				vertex.NeighborList = vertex_neighborList;

				traceInfoDetail_vertexList.Add(vertex);
			}
			traceInfoDetail.VertexList = traceInfoDetail_vertexList;

			List<DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_EntityType> traceInfoDetail_entityTypeList = new List<DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_EntityType>();
			for (int i = 0; i < context.Length("DescribeTraceInfoDetail.TraceInfoDetail.EntityTypeList.Length"); i++) {
				DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_EntityType entityType = new DescribeTraceInfoDetailResponse.DescribeTraceInfoDetail_TraceInfoDetail.DescribeTraceInfoDetail_EntityType();
				entityType.DisplayTemplate = context.StringValue("DescribeTraceInfoDetail.TraceInfoDetail.EntityTypeList["+ i +"].DisplayTemplate");
				entityType.GmtModified = context.LongValue("DescribeTraceInfoDetail.TraceInfoDetail.EntityTypeList["+ i +"].GmtModified");
				entityType.DisplayIcon = context.StringValue("DescribeTraceInfoDetail.TraceInfoDetail.EntityTypeList["+ i +"].DisplayIcon");
				entityType.Offset = context.IntegerValue("DescribeTraceInfoDetail.TraceInfoDetail.EntityTypeList["+ i +"].Offset");
				entityType.DbId = context.IntegerValue("DescribeTraceInfoDetail.TraceInfoDetail.EntityTypeList["+ i +"].DbId");
				entityType.Name = context.StringValue("DescribeTraceInfoDetail.TraceInfoDetail.EntityTypeList["+ i +"].Name");
				entityType._Namespace = context.StringValue("DescribeTraceInfoDetail.TraceInfoDetail.EntityTypeList["+ i +"].Namespace");
				entityType.Limit = context.IntegerValue("DescribeTraceInfoDetail.TraceInfoDetail.EntityTypeList["+ i +"].Limit");
				entityType.Id = context.StringValue("DescribeTraceInfoDetail.TraceInfoDetail.EntityTypeList["+ i +"].Id");
				entityType.DisplayColor = context.StringValue("DescribeTraceInfoDetail.TraceInfoDetail.EntityTypeList["+ i +"].DisplayColor");
				entityType.GmtCreate = context.LongValue("DescribeTraceInfoDetail.TraceInfoDetail.EntityTypeList["+ i +"].GmtCreate");

				traceInfoDetail_entityTypeList.Add(entityType);
			}
			traceInfoDetail.EntityTypeList = traceInfoDetail_entityTypeList;
			describeTraceInfoDetailResponse.TraceInfoDetail = traceInfoDetail;
        
			return describeTraceInfoDetailResponse;
        }
    }
}
