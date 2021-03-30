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
	public class DescribeUserBizTypesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeUserBizTypes_Item> bizTypeList;

		private List<DescribeUserBizTypes_ImportItem> bizTypeListImport;

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

		public List<DescribeUserBizTypes_Item> BizTypeList
		{
			get
			{
				return bizTypeList;
			}
			set	
			{
				bizTypeList = value;
			}
		}

		public List<DescribeUserBizTypes_ImportItem> BizTypeListImport
		{
			get
			{
				return bizTypeListImport;
			}
			set	
			{
				bizTypeListImport = value;
			}
		}

		public class DescribeUserBizTypes_Item
		{

			private string bizType;

			private string sourceBizType;

			private bool? gray;

			private string source;

			private bool? citeTemplate;

			private string industryInfo;

			private string description;

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public string SourceBizType
			{
				get
				{
					return sourceBizType;
				}
				set	
				{
					sourceBizType = value;
				}
			}

			public bool? Gray
			{
				get
				{
					return gray;
				}
				set	
				{
					gray = value;
				}
			}

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public bool? CiteTemplate
			{
				get
				{
					return citeTemplate;
				}
				set	
				{
					citeTemplate = value;
				}
			}

			public string IndustryInfo
			{
				get
				{
					return industryInfo;
				}
				set	
				{
					industryInfo = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}

		public class DescribeUserBizTypes_ImportItem
		{

			private string bizType;

			private string sourceBizType;

			private bool? gray;

			private string source;

			private bool? citeTemplate;

			private string industryInfo;

			private string description;

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public string SourceBizType
			{
				get
				{
					return sourceBizType;
				}
				set	
				{
					sourceBizType = value;
				}
			}

			public bool? Gray
			{
				get
				{
					return gray;
				}
				set	
				{
					gray = value;
				}
			}

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public bool? CiteTemplate
			{
				get
				{
					return citeTemplate;
				}
				set	
				{
					citeTemplate = value;
				}
			}

			public string IndustryInfo
			{
				get
				{
					return industryInfo;
				}
				set	
				{
					industryInfo = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}
	}
}
