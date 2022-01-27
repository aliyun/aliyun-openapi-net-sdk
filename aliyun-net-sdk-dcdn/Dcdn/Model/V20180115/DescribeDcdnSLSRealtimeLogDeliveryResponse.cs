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

namespace Aliyun.Acs.dcdn.Model.V20180115
{
	public class DescribeDcdnSLSRealtimeLogDeliveryResponse : AcsResponse
	{

		private string requestId;

		private DescribeDcdnSLSRealtimeLogDelivery_Content content;

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

		public DescribeDcdnSLSRealtimeLogDelivery_Content Content
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

		public class DescribeDcdnSLSRealtimeLogDelivery_Content
		{

			private string projectName;

			private string domainName;

			private string fieldName;

			private string samplingRate;

			private string dataCenter;

			private string sLSRegion;

			private string sLSProject;

			private string sLSLogStore;

			private string businessType;

			private string type;

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
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

			public string FieldName
			{
				get
				{
					return fieldName;
				}
				set	
				{
					fieldName = value;
				}
			}

			public string SamplingRate
			{
				get
				{
					return samplingRate;
				}
				set	
				{
					samplingRate = value;
				}
			}

			public string DataCenter
			{
				get
				{
					return dataCenter;
				}
				set	
				{
					dataCenter = value;
				}
			}

			public string SLSRegion
			{
				get
				{
					return sLSRegion;
				}
				set	
				{
					sLSRegion = value;
				}
			}

			public string SLSProject
			{
				get
				{
					return sLSProject;
				}
				set	
				{
					sLSProject = value;
				}
			}

			public string SLSLogStore
			{
				get
				{
					return sLSLogStore;
				}
				set	
				{
					sLSLogStore = value;
				}
			}

			public string BusinessType
			{
				get
				{
					return businessType;
				}
				set	
				{
					businessType = value;
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
		}
	}
}
