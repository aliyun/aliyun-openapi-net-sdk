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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeBizTypeImageLibResponse : AcsResponse
	{

		private string requestId;

		private DescribeBizTypeImageLib_Black black;

		private DescribeBizTypeImageLib_Review review;

		private DescribeBizTypeImageLib_White white;

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

		public DescribeBizTypeImageLib_Black Black
		{
			get
			{
				return black;
			}
			set	
			{
				black = value;
			}
		}

		public DescribeBizTypeImageLib_Review Review
		{
			get
			{
				return review;
			}
			set	
			{
				review = value;
			}
		}

		public DescribeBizTypeImageLib_White White
		{
			get
			{
				return white;
			}
			set	
			{
				white = value;
			}
		}

		public class DescribeBizTypeImageLib_Black
		{

			private List<DescribeBizTypeImageLib_WhiteSelectedItem> selected;

			private List<DescribeBizTypeImageLib_WhiteAllItem> all;

			public List<DescribeBizTypeImageLib_WhiteSelectedItem> Selected
			{
				get
				{
					return selected;
				}
				set	
				{
					selected = value;
				}
			}

			public List<DescribeBizTypeImageLib_WhiteAllItem> All
			{
				get
				{
					return all;
				}
				set	
				{
					all = value;
				}
			}

			public class DescribeBizTypeImageLib_WhiteSelectedItem
			{

				private string name;

				private string code;

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
			}

			public class DescribeBizTypeImageLib_WhiteAllItem
			{

				private string name;

				private string code;

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
			}
		}

		public class DescribeBizTypeImageLib_Review
		{

			private List<DescribeBizTypeImageLib_WhiteSelectedItem3> selected1;

			private List<DescribeBizTypeImageLib_WhiteAllItem4> all2;

			public List<DescribeBizTypeImageLib_WhiteSelectedItem3> Selected1
			{
				get
				{
					return selected1;
				}
				set	
				{
					selected1 = value;
				}
			}

			public List<DescribeBizTypeImageLib_WhiteAllItem4> All2
			{
				get
				{
					return all2;
				}
				set	
				{
					all2 = value;
				}
			}

			public class DescribeBizTypeImageLib_WhiteSelectedItem3
			{

				private string name;

				private string code;

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
			}

			public class DescribeBizTypeImageLib_WhiteAllItem4
			{

				private string name;

				private string code;

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
			}
		}

		public class DescribeBizTypeImageLib_White
		{

			private List<DescribeBizTypeImageLib_WhiteSelectedItem7> selected5;

			private List<DescribeBizTypeImageLib_WhiteAllItem8> all6;

			public List<DescribeBizTypeImageLib_WhiteSelectedItem7> Selected5
			{
				get
				{
					return selected5;
				}
				set	
				{
					selected5 = value;
				}
			}

			public List<DescribeBizTypeImageLib_WhiteAllItem8> All6
			{
				get
				{
					return all6;
				}
				set	
				{
					all6 = value;
				}
			}

			public class DescribeBizTypeImageLib_WhiteSelectedItem7
			{

				private string name;

				private string code;

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
			}

			public class DescribeBizTypeImageLib_WhiteAllItem8
			{

				private string name;

				private string code;

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
			}
		}
	}
}
