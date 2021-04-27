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
        public static DescribeGraph4InvestigationOnlineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGraph4InvestigationOnlineResponse describeGraph4InvestigationOnlineResponse = new DescribeGraph4InvestigationOnlineResponse();

			describeGraph4InvestigationOnlineResponse.HttpResponse = _ctx.HttpResponse;
			describeGraph4InvestigationOnlineResponse.RequestId = _ctx.StringValue("DescribeGraph4InvestigationOnline.RequestId");

			DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data data = new DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data();

			List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex> data_vertexList = new List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex>();
			for (int i = 0; i < _ctx.Length("DescribeGraph4InvestigationOnline.Data.VertexList.Length"); i++) {
				DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex vertex = new DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex();
				vertex.Id = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Id");
				vertex.Name = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Name");
				vertex.Type = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Type");
				vertex.Time = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Time");
				vertex.Uuid = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Uuid");
				vertex.Aliuid = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Aliuid");
				vertex.Properties = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Properties");
				vertex.PositionId = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].PositionId");
				vertex.Position = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].Position");

				List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex.DescribeGraph4InvestigationOnline_Neighbor> vertex_neighborList = new List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex.DescribeGraph4InvestigationOnline_Neighbor>();
				for (int j = 0; j < _ctx.Length("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].NeighborList.Length"); j++) {
					DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex.DescribeGraph4InvestigationOnline_Neighbor neighbor = new DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Vertex.DescribeGraph4InvestigationOnline_Neighbor();
					neighbor.Type = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].NeighborList["+ j +"].Type");
					neighbor.Count = _ctx.IntegerValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].NeighborList["+ j +"].Count");
					neighbor.HasMore = _ctx.BooleanValue("DescribeGraph4InvestigationOnline.Data.VertexList["+ i +"].NeighborList["+ j +"].HasMore");

					vertex_neighborList.Add(neighbor);
				}
				vertex.NeighborList = vertex_neighborList;

				data_vertexList.Add(vertex);
			}
			data.VertexList = data_vertexList;

			List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Edge> data_edgeList = new List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Edge>();
			for (int i = 0; i < _ctx.Length("DescribeGraph4InvestigationOnline.Data.EdgeList.Length"); i++) {
				DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Edge edge = new DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_Edge();
				edge.Id = _ctx.IntegerValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].Id");
				edge.StartId = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].StartId");
				edge.EndId = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].EndId");
				edge.StartType = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].StartType");
				edge.EndType = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].EndType");
				edge.Name = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].Name");
				edge.Type = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].Type");
				edge.Time = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.EdgeList["+ i +"].Time");

				data_edgeList.Add(edge);
			}
			data.EdgeList = data_edgeList;

			List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_EntityType> data_entityTypeList = new List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_EntityType>();
			for (int i = 0; i < _ctx.Length("DescribeGraph4InvestigationOnline.Data.EntityTypeList.Length"); i++) {
				DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_EntityType entityType = new DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_EntityType();
				entityType.Id = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.EntityTypeList["+ i +"].Id");
				entityType.Name = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.EntityTypeList["+ i +"].Name");
				entityType.DisplayColor = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.EntityTypeList["+ i +"].DisplayColor");
				entityType.DisplayIcon = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.EntityTypeList["+ i +"].DisplayIcon");
				entityType.DisplayOrder = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.EntityTypeList["+ i +"].DisplayOrder");

				data_entityTypeList.Add(entityType);
			}
			data.EntityTypeList = data_entityTypeList;

			List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_RelationType> data_relationTypeList = new List<DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_RelationType>();
			for (int i = 0; i < _ctx.Length("DescribeGraph4InvestigationOnline.Data.RelationTypeList.Length"); i++) {
				DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_RelationType relationType = new DescribeGraph4InvestigationOnlineResponse.DescribeGraph4InvestigationOnline_Data.DescribeGraph4InvestigationOnline_RelationType();
				relationType.Id = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.RelationTypeList["+ i +"].Id");
				relationType.ShowType = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.RelationTypeList["+ i +"].ShowType");
				relationType.Directed = _ctx.IntegerValue("DescribeGraph4InvestigationOnline.Data.RelationTypeList["+ i +"].Directed");
				relationType.Name = _ctx.StringValue("DescribeGraph4InvestigationOnline.Data.RelationTypeList["+ i +"].Name");

				data_relationTypeList.Add(relationType);
			}
			data.RelationTypeList = data_relationTypeList;
			describeGraph4InvestigationOnlineResponse.Data = data;
        
			return describeGraph4InvestigationOnlineResponse;
        }
    }
}
