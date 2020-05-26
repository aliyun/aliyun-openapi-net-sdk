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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeGraph4InvestigationOnlineResponseUnmarshaller
    {
        public static DescribeGraph4InvestigationOnlineResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGraph4InvestigationOnlineResponse describeGraph4InvestigationOnlineResponse = new DescribeGraph4InvestigationOnlineResponse();

			describeGraph4InvestigationOnlineResponse.HttpResponse = context.HttpResponse;
			describeGraph4InvestigationOnlineResponse.RequestId = context.StringValue("DescribeGraph4InvestigationOnline.RequestId");

			DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data data = new DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data();

			List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex> data_vertexList = new List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex>();
			for (int i = 0; i < context.Length("DescribeGraph4InvestigationOnline.Data.VertexList.Length"); i++) {
				DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex vertex = new DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex();
				vertex.Id = context.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Id");
				vertex.Name = context.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Name");
				vertex.Type = context.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Type");
				vertex.Time = context.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Time");
				vertex.Uuid = context.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Uuid");
				vertex.Aliuid = context.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Aliuid");
				vertex.Properties = context.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Properties");
				vertex.PositionId = context.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].PositionId");
				vertex.Position = context.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Position");

				List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex.DescribeGraph4InvestigationOnline_Neighbor> vertex_neighborList = new List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex.DescribeGraph4InvestigationOnline_Neighbor>();
				for (int j = 0; j < context.Length("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].NeighborList.Length"); j++) {
					DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex.DescribeGraph4InvestigationOnline_Neighbor neighbor = new DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex.DescribeGraph4InvestigationOnline_Neighbor();
					neighbor.Type = context.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].NeighborList["+ j +"].Type");
					neighbor.Count = context.IntegerValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].NeighborList["+ j +"].Count");
					neighbor.HasMore = context.BooleanValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].NeighborList["+ j +"].HasMore");

					vertex_neighborList.Add(neighbor);
				}
				vertex.NeighborList = vertex_neighborList;

				data_vertexList.Add(vertex);
			}
			data.VertexList = data_vertexList;

			List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Edge> data_edgeList = new List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Edge>();
			for (int i = 0; i < context.Length("DescribeGraph4InvestigationOnline.Data.EdgeList.Length"); i++) {
				DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Edge edge = new DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Edge();
				edge.Id = context.IntegerValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].Id");
				edge.StartId = context.StringValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].StartId");
				edge.EndId = context.StringValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].EndId");
				edge.StartType = context.StringValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].StartType");
				edge.EndType = context.StringValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].EndType");
				edge.Name = context.StringValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].Name");
				edge.Type = context.StringValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].Type");
				edge.Time = context.StringValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].Time");

				data_edgeList.Add(edge);
			}
			data.EdgeList = data_edgeList;

			List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_EntityType> data_entityTypeList = new List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_EntityType>();
			for (int i = 0; i < context.Length("DescribeGraph4InvestigationOnline.Data.EntityTypeList.Length"); i++) {
				DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_EntityType entityType = new DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_EntityType();
				entityType.Id = context.StringValue("DescribeGraph4InvestigationOnline.Data.EntityTypeList["+ i +"].Id");
				entityType.Name = context.StringValue("DescribeGraph4InvestigationOnline.Data.EntityTypeList["+ i +"].Name");
				entityType.DisplayColor = context.StringValue("DescribeGraph4InvestigationOnline.Data.EntityTypeList["+ i +"].DisplayColor");
				entityType.DisplayIcon = context.StringValue("DescribeGraph4InvestigationOnline.Data.EntityTypeList["+ i +"].DisplayIcon");
				entityType.DisplayOrder = context.StringValue("DescribeGraph4InvestigationOnline.Data.EntityTypeList["+ i +"].DisplayOrder");

				data_entityTypeList.Add(entityType);
			}
			data.EntityTypeList = data_entityTypeList;

			List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_RelationType> data_relationTypeList = new List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_RelationType>();
			for (int i = 0; i < context.Length("DescribeGraph4InvestigationOnline.Data.RelationTypeList.Length"); i++) {
				DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_RelationType relationType = new DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_RelationType();
				relationType.Id = context.StringValue("DescribeGraph4InvestigationOnline.Data.RelationTypeList["+ i +"].Id");
				relationType.ShowType = context.StringValue("DescribeGraph4InvestigationOnline.Data.RelationTypeList["+ i +"].ShowType");
				relationType.Directed = context.IntegerValue("DescribeGraph4InvestigationOnline.Data.RelationTypeList["+ i +"].Directed");
				relationType.Name = context.StringValue("DescribeGraph4InvestigationOnline.Data.RelationTypeList["+ i +"].Name");

				data_relationTypeList.Add(relationType);
			}
			data.RelationTypeList = data_relationTypeList;
			describeGraph4InvestigationOnlineResponse.Data = data;
        
			return describeGraph4InvestigationOnlineResponse;
        }
    }
}
