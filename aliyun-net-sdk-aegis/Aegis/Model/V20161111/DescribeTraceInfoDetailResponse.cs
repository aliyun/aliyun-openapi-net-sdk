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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeTraceInfoDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private DescribeTraceInfoDetail_TraceInfoDetail traceInfoDetail;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public DescribeTraceInfoDetail_TraceInfoDetail TraceInfoDetail
		{
			get
			{
				return traceInfoDetail;
			}
			set	
			{
				traceInfoDetail = value;
			}
		}

		public class DescribeTraceInfoDetail_TraceInfoDetail
		{

			private List<DescribeTraceInfoDetail_Edge> edgeList;

			private List<DescribeTraceInfoDetail_Vertex> vertexList;

			private List<DescribeTraceInfoDetail_EntityType> entityTypeList;

			public List<DescribeTraceInfoDetail_Edge> EdgeList
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

			public List<DescribeTraceInfoDetail_Vertex> VertexList
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

			public List<DescribeTraceInfoDetail_EntityType> EntityTypeList
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

			public class DescribeTraceInfoDetail_Edge
			{

				private string endId;

				private string startId;

				private int? count;

				private string time;

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

			public class DescribeTraceInfoDetail_Vertex
			{

				private string name;

				private int? count;

				private string id;

				private string time;

				private string type;

				private List<DescribeTraceInfoDetail_Neighbor> neighborList;

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

				public List<DescribeTraceInfoDetail_Neighbor> NeighborList
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

				public class DescribeTraceInfoDetail_Neighbor
				{

					private bool? hasMore;

					private int? count;

					private string type;

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
				}
			}

			public class DescribeTraceInfoDetail_EntityType
			{

				private string displayTemplate;

				private long? gmtModified;

				private string displayIcon;

				private int? offset;

				private int? dbId;

				private string name;

				private string _namespace;

				private int? limit;

				private string id;

				private string displayColor;

				private long? gmtCreate;

				public string DisplayTemplate
				{
					get
					{
						return displayTemplate;
					}
					set	
					{
						displayTemplate = value;
					}
				}

				public long? GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
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

				public int? Offset
				{
					get
					{
						return offset;
					}
					set	
					{
						offset = value;
					}
				}

				public int? DbId
				{
					get
					{
						return dbId;
					}
					set	
					{
						dbId = value;
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

				public string _Namespace
				{
					get
					{
						return _namespace;
					}
					set	
					{
						_namespace = value;
					}
				}

				public int? Limit
				{
					get
					{
						return limit;
					}
					set	
					{
						limit = value;
					}
				}

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

				public long? GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}
			}
		}
	}
}
