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

namespace Aliyun.Acs.Airec.Model.V20181012
{
	public class ListDashboardResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private ListDashboard_Result result;

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

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public ListDashboard_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListDashboard_Result
		{

			private int? num;

			private List<ListDashboard_ListItem> list;

			public int? Num
			{
				get
				{
					return num;
				}
				set	
				{
					num = value;
				}
			}

			public List<ListDashboard_ListItem> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListDashboard_ListItem
			{

				private long? bizDate;

				private long? pv;

				private long? uv;

				private long? click;

				private float? ctr;

				private float? uvCtr;

				private float? perUvBhv;

				private float? perUvClick;

				private long? clickUser;

				private long? activeItem;

				private string traceId;

				private string sceneId;

				public long? BizDate
				{
					get
					{
						return bizDate;
					}
					set	
					{
						bizDate = value;
					}
				}

				public long? Pv
				{
					get
					{
						return pv;
					}
					set	
					{
						pv = value;
					}
				}

				public long? Uv
				{
					get
					{
						return uv;
					}
					set	
					{
						uv = value;
					}
				}

				public long? Click
				{
					get
					{
						return click;
					}
					set	
					{
						click = value;
					}
				}

				public float? Ctr
				{
					get
					{
						return ctr;
					}
					set	
					{
						ctr = value;
					}
				}

				public float? UvCtr
				{
					get
					{
						return uvCtr;
					}
					set	
					{
						uvCtr = value;
					}
				}

				public float? PerUvBhv
				{
					get
					{
						return perUvBhv;
					}
					set	
					{
						perUvBhv = value;
					}
				}

				public float? PerUvClick
				{
					get
					{
						return perUvClick;
					}
					set	
					{
						perUvClick = value;
					}
				}

				public long? ClickUser
				{
					get
					{
						return clickUser;
					}
					set	
					{
						clickUser = value;
					}
				}

				public long? ActiveItem
				{
					get
					{
						return activeItem;
					}
					set	
					{
						activeItem = value;
					}
				}

				public string TraceId
				{
					get
					{
						return traceId;
					}
					set	
					{
						traceId = value;
					}
				}

				public string SceneId
				{
					get
					{
						return sceneId;
					}
					set	
					{
						sceneId = value;
					}
				}
			}
		}
	}
}
