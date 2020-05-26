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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeGraph4InvestigationOnlineResponse : AcsResponse
	{

		private string requestId;

		private DescribeGraph4InvestigationOnline_Data data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public DescribeGraph4InvestigationOnline_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeGraph4InvestigationOnline_Data
		{

			private List<DescribeGraph4InvestigationOnline_Vertex> vertexList;

			private List<DescribeGraph4InvestigationOnline_Edge> edgeList;

			private List<DescribeGraph4InvestigationOnline_EntityType> entityTypeList;

			private List<DescribeGraph4InvestigationOnline_RelationType> relationTypeList;

			public List<DescribeGraph4InvestigationOnline_Vertex> VertexList
			{
				get
				{
					return vertexList;
				}
				set	
				{
					vertexList = value;
				}
			}

			public List<DescribeGraph4InvestigationOnline_Edge> EdgeList
			{
				get
				{
					return edgeList;
				}
				set	
				{
					edgeList = value;
				}
			}

			public List<DescribeGraph4InvestigationOnline_EntityType> EntityTypeList
			{
				get
				{
					return entityTypeList;
				}
				set	
				{
					entityTypeList = value;
				}
			}

			public List<DescribeGraph4InvestigationOnline_RelationType> RelationTypeList
			{
				get
				{
					return relationTypeList;
				}
				set	
				{
					relationTypeList = value;
				}
			}

			public class DescribeGraph4InvestigationOnline_Vertex
			{

				private string id;

				private string name;

				private string type;

				private string time;

				private string uuid;

				private string aliuid;

				private string properties;

				private string positionId;

				private string position;

				private List<DescribeGraph4InvestigationOnline_Neighbor> neighborList;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				public string Uuid
				{
					get
					{
						return uuid;
					}
					set	
					{
						uuid = value;
					}
				}

				public string Aliuid
				{
					get
					{
						return aliuid;
					}
					set	
					{
						aliuid = value;
					}
				}

				public string Properties
				{
					get
					{
						return properties;
					}
					set	
					{
						properties = value;
					}
				}

				public string PositionId
				{
					get
					{
						return positionId;
					}
					set	
					{
						positionId = value;
					}
				}

				public string Position
				{
					get
					{
						return position;
					}
					set	
					{
						position = value;
					}
				}

				public List<DescribeGraph4InvestigationOnline_Neighbor> NeighborList
				{
					get
					{
						return neighborList;
					}
					set	
					{
						neighborList = value;
					}
				}

				public class DescribeGraph4InvestigationOnline_Neighbor
				{

					private string type;

					private int? count;

					private bool? hasMore;

					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
						}
					}

					public int? Count
					{
						get
						{
							return count;
						}
						set	
						{
							count = value;
						}
					}

					public bool? HasMore
					{
						get
						{
							return hasMore;
						}
						set	
						{
							hasMore = value;
						}
					}
				}
			}

			public class DescribeGraph4InvestigationOnline_Edge
			{

				private int? id;

				private string startId;

				private string endId;

				private string startType;

				private string endType;

				private string name;

				private string type;

				private string time;

				public int? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string StartId
				{
					get
					{
						return startId;
					}
					set	
					{
						startId = value;
					}
				}

				public string EndId
				{
					get
					{
						return endId;
					}
					set	
					{
						endId = value;
					}
				}

				public string StartType
				{
					get
					{
						return startType;
					}
					set	
					{
						startType = value;
					}
				}

				public string EndType
				{
					get
					{
						return endType;
					}
					set	
					{
						endType = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}
			}

			public class DescribeGraph4InvestigationOnline_EntityType
			{

				private string id;

				private string name;

				private string displayColor;

				private string displayIcon;

				private string displayOrder;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string DisplayColor
				{
					get
					{
						return displayColor;
					}
					set	
					{
						displayColor = value;
					}
				}

				public string DisplayIcon
				{
					get
					{
						return displayIcon;
					}
					set	
					{
						displayIcon = value;
					}
				}

				public string DisplayOrder
				{
					get
					{
						return displayOrder;
					}
					set	
					{
						displayOrder = value;
					}
				}
			}

			public class DescribeGraph4InvestigationOnline_RelationType
			{

				private string id;

				private string showType;

				private int? directed;

				private string name;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string ShowType
				{
					get
					{
						return showType;
					}
					set	
					{
						showType = value;
					}
				}

				public int? Directed
				{
					get
					{
						return directed;
					}
					set	
					{
						directed = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}
			}
		}
	}
}
