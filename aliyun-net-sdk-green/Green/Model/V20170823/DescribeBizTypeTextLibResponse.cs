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
	public class DescribeBizTypeTextLibResponse : AcsResponse
	{

		private string requestId;

		private DescribeBizTypeTextLib_Black black;

		private DescribeBizTypeTextLib_Review review;

		private DescribeBizTypeTextLib_Ignore ignore;

		private DescribeBizTypeTextLib_White white;

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

		public DescribeBizTypeTextLib_Black Black
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

		public DescribeBizTypeTextLib_Review Review
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

		public DescribeBizTypeTextLib_Ignore Ignore
		{
			get
			{
				return ignore;
			}
			set	
			{
				ignore = value;
			}
		}

		public DescribeBizTypeTextLib_White White
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

		public class DescribeBizTypeTextLib_Black
		{

			private List<DescribeBizTypeTextLib_WhiteSelectedItem> selected;

			private List<DescribeBizTypeTextLib_WhiteAllItem> all;

			public List<DescribeBizTypeTextLib_WhiteSelectedItem> Selected
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

			public List<DescribeBizTypeTextLib_WhiteAllItem> All
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

			public class DescribeBizTypeTextLib_WhiteSelectedItem
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

			public class DescribeBizTypeTextLib_WhiteAllItem
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

		public class DescribeBizTypeTextLib_Review
		{

			private List<DescribeBizTypeTextLib_WhiteSelectedItem3> selected1;

			private List<DescribeBizTypeTextLib_WhiteAllItem4> all2;

			public List<DescribeBizTypeTextLib_WhiteSelectedItem3> Selected1
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

			public List<DescribeBizTypeTextLib_WhiteAllItem4> All2
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

			public class DescribeBizTypeTextLib_WhiteSelectedItem3
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

			public class DescribeBizTypeTextLib_WhiteAllItem4
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

		public class DescribeBizTypeTextLib_Ignore
		{

			private List<DescribeBizTypeTextLib_WhiteSelectedItem7> selected5;

			private List<DescribeBizTypeTextLib_WhiteAllItem8> all6;

			public List<DescribeBizTypeTextLib_WhiteSelectedItem7> Selected5
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

			public List<DescribeBizTypeTextLib_WhiteAllItem8> All6
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

			public class DescribeBizTypeTextLib_WhiteSelectedItem7
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

			public class DescribeBizTypeTextLib_WhiteAllItem8
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

		public class DescribeBizTypeTextLib_White
		{

			private List<DescribeBizTypeTextLib_WhiteSelectedItem11> selected9;

			private List<DescribeBizTypeTextLib_WhiteAllItem12> all10;

			public List<DescribeBizTypeTextLib_WhiteSelectedItem11> Selected9
			{
				get
				{
					return selected9;
				}
				set	
				{
					selected9 = value;
				}
			}

			public List<DescribeBizTypeTextLib_WhiteAllItem12> All10
			{
				get
				{
					return all10;
				}
				set	
				{
					all10 = value;
				}
			}

			public class DescribeBizTypeTextLib_WhiteSelectedItem11
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

			public class DescribeBizTypeTextLib_WhiteAllItem12
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
