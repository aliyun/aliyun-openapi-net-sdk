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
	public class AddWaterMarkTemplateResponse : AcsResponse
	{

		private WaterMarkTemplate_ waterMarkTemplate;

		public WaterMarkTemplate_ WaterMarkTemplate
		{
			get
			{
				return waterMarkTemplate;
			}
			set	
			{
				waterMarkTemplate = value;
			}
		}

		public class WaterMarkTemplate_{

			private string id;

			private string name;

			private string width;

			private string height;

			private string dx;

			private string dy;

			private string referPos;

			private string type;

			private string state;

			private Timeline_ timeline;

			private RatioRefer_ ratioRefer;

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

			public Timeline_ Timeline
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

			public RatioRefer_ RatioRefer
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

			public class Timeline_{

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

			public class RatioRefer_{

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