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
	public class DescribeWebInstanceRelationsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeWebInstanceRelations_WebInstanceRelation> webInstanceRelations;

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

		public List<DescribeWebInstanceRelations_WebInstanceRelation> WebInstanceRelations
		{
			get
			{
				return webInstanceRelations;
			}
			set	
			{
				webInstanceRelations = value;
			}
		}

		public class DescribeWebInstanceRelations_WebInstanceRelation
		{

			private string domain;

			private List<DescribeWebInstanceRelations_InstanceDetail> instanceDetails;

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public List<DescribeWebInstanceRelations_InstanceDetail> InstanceDetails
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

			public class DescribeWebInstanceRelations_InstanceDetail
			{

				private string instanceId;

				private string functionVersion;

				private List<string> eipList;

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

				public string FunctionVersion
				{
					get
					{
						return functionVersion;
					}
					set	
					{
						functionVersion = value;
					}
				}

				public List<string> EipList
				{
					get
					{
						return eipList;
					}
					set	
					{
						eipList = value;
					}
				}
			}
		}
	}
}
