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
	public class DescribeDomainPnoDataResponse : AcsResponse
	{

		private string requestId;

		private string startTime;

		private string endTime;

		private int? pageSize;

		private int? pageNumber;

		private string domainName;

		private List<DescribeDomainPnoData_PnoDataModel> pnoDataModels;

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

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

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

		public List<DescribeDomainPnoData_PnoDataModel> PnoDataModels
		{
			get
			{
				return pnoDataModels;
			}
			set	
			{
				pnoDataModels = value;
			}
		}

		public class DescribeDomainPnoData_PnoDataModel
		{

			private string pno;

			private List<DescribeDomainPnoData_Detail> details;

			public string Pno
			{
				get
				{
					return pno;
				}
				set	
				{
					pno = value;
				}
			}

			public List<DescribeDomainPnoData_Detail> Details
			{
				get
				{
					return details;
				}
				set	
				{
					details = value;
				}
			}

			public class DescribeDomainPnoData_Detail
			{

				private string timeStamp;

				private float? bandWidth;

				public string TimeStamp
				{
					get
					{
						return timeStamp;
					}
					set	
					{
						timeStamp = value;
					}
				}

				public float? BandWidth
				{
					get
					{
						return bandWidth;
					}
					set	
					{
						bandWidth = value;
					}
				}
			}
		}
	}
}