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
	public class DescribeTraceInfoNodeListResponse : AcsResponse
	{

		private string requestId;

		private DescribeTraceInfoNodeList_NodeListInfo nodeListInfo;

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

		public DescribeTraceInfoNodeList_NodeListInfo NodeListInfo
		{
			get
			{
				return nodeListInfo;
			}
			set	
			{
				nodeListInfo = value;
			}
		}

		public class DescribeTraceInfoNodeList_NodeListInfo
		{

			private List<DescribeTraceInfoNodeList_Edge> edgeList;

			private List<DescribeTraceInfoNodeList_Vertex> vertexList;

			private List<string> entityTypeList;

			public List<DescribeTraceInfoNodeList_Edge> EdgeList
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

			public List<DescribeTraceInfoNodeList_Vertex> VertexList
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

			public List<string> EntityTypeList
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

			public class DescribeTraceInfoNodeList_Edge
			{

				private string endId;

				private string startId;

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

			public class DescribeTraceInfoNodeList_Vertex
			{

				private string name;

				private string id;

				private string time;

				private List<string> neighborList;

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

				public List<string> NeighborList
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
			}
		}
	}
}
