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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class QueryWaterMarkTemplateListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryWaterMarkTemplateList_WaterMarkTemplate> waterMarkTemplateList;

		private List<string> nonExistWids;

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

		public List<QueryWaterMarkTemplateList_WaterMarkTemplate> WaterMarkTemplateList
		{
			get
			{
				return waterMarkTemplateList;
			}
			set	
			{
				waterMarkTemplateList = value;
			}
		}

		public List<string> NonExistWids
		{
			get
			{
				return nonExistWids;
			}
			set	
			{
				nonExistWids = value;
			}
		}

		public class QueryWaterMarkTemplateList_WaterMarkTemplate
		{

			private string id;

			private string name;

			private string width;

			private string height;

			private string dx;

			private string dy;

			private string referPos;

			private string type;

			private string state;

			private QueryWaterMarkTemplateList_Timeline timeline;

			private QueryWaterMarkTemplateList_RatioRefer ratioRefer;

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

			public string Width
			{
				get
				{
					return width;
				}
				set	
				{
					width = value;
				}
			}

			public string Height
			{
				get
				{
					return height;
				}
				set	
				{
					height = value;
				}
			}

			public string Dx
			{
				get
				{
					return dx;
				}
				set	
				{
					dx = value;
				}
			}

			public string Dy
			{
				get
				{
					return dy;
				}
				set	
				{
					dy = value;
				}
			}

			public string ReferPos
			{
				get
				{
					return referPos;
				}
				set	
				{
					referPos = value;
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

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public QueryWaterMarkTemplateList_Timeline Timeline
			{
				get
				{
					return timeline;
				}
				set	
				{
					timeline = value;
				}
			}

			public QueryWaterMarkTemplateList_RatioRefer RatioRefer
			{
				get
				{
					return ratioRefer;
				}
				set	
				{
					ratioRefer = value;
				}
			}

			public class QueryWaterMarkTemplateList_Timeline
			{

				private string start;

				private string duration;

				public string Start
				{
					get
					{
						return start;
					}
					set	
					{
						start = value;
					}
				}

				public string Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
					}
				}
			}

			public class QueryWaterMarkTemplateList_RatioRefer
			{

				private string dx;

				private string dy;

				private string width;

				private string height;

				public string Dx
				{
					get
					{
						return dx;
					}
					set	
					{
						dx = value;
					}
				}

				public string Dy
				{
					get
					{
						return dy;
					}
					set	
					{
						dy = value;
					}
				}

				public string Width
				{
					get
					{
						return width;
					}
					set	
					{
						width = value;
					}
				}

				public string Height
				{
					get
					{
						return height;
					}
					set	
					{
						height = value;
					}
				}
			}
		}
	}
}