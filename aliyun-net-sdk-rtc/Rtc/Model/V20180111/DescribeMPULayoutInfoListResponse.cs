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

namespace Aliyun.Acs.rtc.Model.V20180111
{
	public class DescribeMPULayoutInfoListResponse : AcsResponse
	{

		private string requestId;

		private long? totalNum;

		private long? totalPage;

		private List<DescribeMPULayoutInfoList_Layout> layouts;

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

		public long? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		public long? TotalPage
		{
			get
			{
				return totalPage;
			}
			set	
			{
				totalPage = value;
			}
		}

		public List<DescribeMPULayoutInfoList_Layout> Layouts
		{
			get
			{
				return layouts;
			}
			set	
			{
				layouts = value;
			}
		}

		public class DescribeMPULayoutInfoList_Layout
		{

			private long? layoutId;

			private string name;

			private int? audioMixCount;

			private List<DescribeMPULayoutInfoList_PanesItem> panes;

			public long? LayoutId
			{
				get
				{
					return layoutId;
				}
				set	
				{
					layoutId = value;
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

			public int? AudioMixCount
			{
				get
				{
					return audioMixCount;
				}
				set	
				{
					audioMixCount = value;
				}
			}

			public List<DescribeMPULayoutInfoList_PanesItem> Panes
			{
				get
				{
					return panes;
				}
				set	
				{
					panes = value;
				}
			}

			public class DescribeMPULayoutInfoList_PanesItem
			{

				private int? paneId;

				private int? majorPane;

				private float? x;

				private float? y;

				private float? width;

				private float? height;

				private int? zOrder;

				public int? PaneId
				{
					get
					{
						return paneId;
					}
					set	
					{
						paneId = value;
					}
				}

				public int? MajorPane
				{
					get
					{
						return majorPane;
					}
					set	
					{
						majorPane = value;
					}
				}

				public float? X
				{
					get
					{
						return x;
					}
					set	
					{
						x = value;
					}
				}

				public float? Y
				{
					get
					{
						return y;
					}
					set	
					{
						y = value;
					}
				}

				public float? Width
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

				public float? Height
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

				public int? ZOrder
				{
					get
					{
						return zOrder;
					}
					set	
					{
						zOrder = value;
					}
				}
			}
		}
	}
}
