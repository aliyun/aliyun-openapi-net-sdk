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

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeDomainTopUrlVisitResponse : AcsResponse
	{

		private string domainName;

		private string startTime;

		private List<UrlList> allUrlList;

		private List<UrlList> url200List;

		private List<UrlList> url300List;

		private List<UrlList> url400List;

		private List<UrlList> url500List;

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

		public List<UrlList> AllUrlList
		{
			get
			{
				return allUrlList;
			}
			set	
			{
				allUrlList = value;
			}
		}

		public List<UrlList> Url200List
		{
			get
			{
				return url200List;
			}
			set	
			{
				url200List = value;
			}
		}

		public List<UrlList> Url300List
		{
			get
			{
				return url300List;
			}
			set	
			{
				url300List = value;
			}
		}

		public List<UrlList> Url400List
		{
			get
			{
				return url400List;
			}
			set	
			{
				url400List = value;
			}
		}

		public List<UrlList> Url500List
		{
			get
			{
				return url500List;
			}
			set	
			{
				url500List = value;
			}
		}

		public class UrlList{

			private string urlDetail;

			private string visitData;

			public string UrlDetail
			{
				get
				{
					return urlDetail;
				}
				set	
				{
					urlDetail = value;
				}
			}

			public string VisitData
			{
				get
				{
					return visitData;
				}
				set	
				{
					visitData = value;
				}
			}
		}

		public class UrlList{

			private string urlDetail;

			private string visitData;

			public string UrlDetail
			{
				get
				{
					return urlDetail;
				}
				set	
				{
					urlDetail = value;
				}
			}

			public string VisitData
			{
				get
				{
					return visitData;
				}
				set	
				{
					visitData = value;
				}
			}
		}

		public class UrlList{

			private string urlDetail;

			private string visitData;

			public string UrlDetail
			{
				get
				{
					return urlDetail;
				}
				set	
				{
					urlDetail = value;
				}
			}

			public string VisitData
			{
				get
				{
					return visitData;
				}
				set	
				{
					visitData = value;
				}
			}
		}

		public class UrlList{

			private string urlDetail;

			private string visitData;

			public string UrlDetail
			{
				get
				{
					return urlDetail;
				}
				set	
				{
					urlDetail = value;
				}
			}

			public string VisitData
			{
				get
				{
					return visitData;
				}
				set	
				{
					visitData = value;
				}
			}
		}

		public class UrlList{

			private string urlDetail;

			private string visitData;

			public string UrlDetail
			{
				get
				{
					return urlDetail;
				}
				set	
				{
					urlDetail = value;
				}
			}

			public string VisitData
			{
				get
				{
					return visitData;
				}
				set	
				{
					visitData = value;
				}
			}
		}
	}
}