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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeVulDetailsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeVulDetails_Cve> cves;

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

		public List<DescribeVulDetails_Cve> Cves
		{
			get
			{
				return cves;
			}
			set	
			{
				cves = value;
			}
		}

		public class DescribeVulDetails_Cve
		{

			private string cveId;

			private string cnvdId;

			private string otherId;

			private string title;

			private string cvssScore;

			private string cvssVector;

			private long? releaseTime;

			private string complexity;

			private string poc;

			private long? pocCreateTime;

			private long? pocDisclosureTime;

			private string summary;

			private string solution;

			private string content;

			private string vendor;

			private string product;

			private string vulLevel;

			private string reference;

			private string classify;

			private List<DescribeVulDetails_Classify> classifys;

			public string CveId
			{
				get
				{
					return cveId;
				}
				set	
				{
					cveId = value;
				}
			}

			public string CnvdId
			{
				get
				{
					return cnvdId;
				}
				set	
				{
					cnvdId = value;
				}
			}

			public string OtherId
			{
				get
				{
					return otherId;
				}
				set	
				{
					otherId = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string CvssScore
			{
				get
				{
					return cvssScore;
				}
				set	
				{
					cvssScore = value;
				}
			}

			public string CvssVector
			{
				get
				{
					return cvssVector;
				}
				set	
				{
					cvssVector = value;
				}
			}

			public long? ReleaseTime
			{
				get
				{
					return releaseTime;
				}
				set	
				{
					releaseTime = value;
				}
			}

			public string Complexity
			{
				get
				{
					return complexity;
				}
				set	
				{
					complexity = value;
				}
			}

			public string Poc
			{
				get
				{
					return poc;
				}
				set	
				{
					poc = value;
				}
			}

			public long? PocCreateTime
			{
				get
				{
					return pocCreateTime;
				}
				set	
				{
					pocCreateTime = value;
				}
			}

			public long? PocDisclosureTime
			{
				get
				{
					return pocDisclosureTime;
				}
				set	
				{
					pocDisclosureTime = value;
				}
			}

			public string Summary
			{
				get
				{
					return summary;
				}
				set	
				{
					summary = value;
				}
			}

			public string Solution
			{
				get
				{
					return solution;
				}
				set	
				{
					solution = value;
				}
			}

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string Vendor
			{
				get
				{
					return vendor;
				}
				set	
				{
					vendor = value;
				}
			}

			public string Product
			{
				get
				{
					return product;
				}
				set	
				{
					product = value;
				}
			}

			public string VulLevel
			{
				get
				{
					return vulLevel;
				}
				set	
				{
					vulLevel = value;
				}
			}

			public string Reference
			{
				get
				{
					return reference;
				}
				set	
				{
					reference = value;
				}
			}

			public string Classify
			{
				get
				{
					return classify;
				}
				set	
				{
					classify = value;
				}
			}

			public List<DescribeVulDetails_Classify> Classifys
			{
				get
				{
					return classifys;
				}
				set	
				{
					classifys = value;
				}
			}

			public class DescribeVulDetails_Classify
			{

				private string classify;

				private string description;

				private string demoVideoUrl;

				public string Classify
				{
					get
					{
						return classify;
					}
					set	
					{
						classify = value;
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

				public string DemoVideoUrl
				{
					get
					{
						return demoVideoUrl;
					}
					set	
					{
						demoVideoUrl = value;
					}
				}
			}
		}
	}
}
