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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeInstanceDetailsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeInstanceDetails_InstanceDetail> instanceDetails;

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

		public List<DescribeInstanceDetails_InstanceDetail> InstanceDetails
		{
			get
			{
				return instanceDetails;
			}
			set	
			{
				instanceDetails = value;
			}
		}

		public class DescribeInstanceDetails_InstanceDetail
		{

			private string instanceId;

			private string line;

			private List<DescribeInstanceDetails_EipInfo> eipInfos;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string Line
			{
				get
				{
					return line;
				}
				set	
				{
					line = value;
				}
			}

			public List<DescribeInstanceDetails_EipInfo> EipInfos
			{
				get
				{
					return eipInfos;
				}
				set	
				{
					eipInfos = value;
				}
			}

			public class DescribeInstanceDetails_EipInfo
			{

				private string eip;

				private string status;

				public string Eip
				{
					get
					{
						return eip;
					}
					set	
					{
						eip = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}
		}
	}
}
