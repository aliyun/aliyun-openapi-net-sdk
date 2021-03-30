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
	public class DescribeBizTypeSettingResponse : AcsResponse
	{

		private string requestId;

		private DescribeBizTypeSetting_Terrorism terrorism;

		private DescribeBizTypeSetting_Porn porn;

		private DescribeBizTypeSetting_Antispam antispam;

		private DescribeBizTypeSetting_Ad ad;

		private DescribeBizTypeSetting_Live live;

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

		public DescribeBizTypeSetting_Terrorism Terrorism
		{
			get
			{
				return terrorism;
			}
			set	
			{
				terrorism = value;
			}
		}

		public DescribeBizTypeSetting_Porn Porn
		{
			get
			{
				return porn;
			}
			set	
			{
				porn = value;
			}
		}

		public DescribeBizTypeSetting_Antispam Antispam
		{
			get
			{
				return antispam;
			}
			set	
			{
				antispam = value;
			}
		}

		public DescribeBizTypeSetting_Ad Ad
		{
			get
			{
				return ad;
			}
			set	
			{
				ad = value;
			}
		}

		public DescribeBizTypeSetting_Live Live
		{
			get
			{
				return live;
			}
			set	
			{
				live = value;
			}
		}

		public class DescribeBizTypeSetting_Terrorism
		{

			private List<string> categories;

			public List<string> Categories
			{
				get
				{
					return categories;
				}
				set	
				{
					categories = value;
				}
			}
		}

		public class DescribeBizTypeSetting_Porn
		{

			private List<string> categories1;

			public List<string> Categories1
			{
				get
				{
					return categories1;
				}
				set	
				{
					categories1 = value;
				}
			}
		}

		public class DescribeBizTypeSetting_Antispam
		{

			private List<string> categories2;

			public List<string> Categories2
			{
				get
				{
					return categories2;
				}
				set	
				{
					categories2 = value;
				}
			}
		}

		public class DescribeBizTypeSetting_Ad
		{

			private List<string> categories3;

			public List<string> Categories3
			{
				get
				{
					return categories3;
				}
				set	
				{
					categories3 = value;
				}
			}
		}

		public class DescribeBizTypeSetting_Live
		{

			private List<string> categories4;

			public List<string> Categories4
			{
				get
				{
					return categories4;
				}
				set	
				{
					categories4 = value;
				}
			}
		}
	}
}
