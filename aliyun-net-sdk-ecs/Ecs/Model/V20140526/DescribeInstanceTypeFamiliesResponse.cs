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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeInstanceTypeFamiliesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeInstanceTypeFamilies_InstanceTypeFamily> instanceTypeFamilies;

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

		public List<DescribeInstanceTypeFamilies_InstanceTypeFamily> InstanceTypeFamilies
		{
			get
			{
				return instanceTypeFamilies;
			}
			set	
			{
				instanceTypeFamilies = value;
			}
		}

		public class DescribeInstanceTypeFamilies_InstanceTypeFamily
		{

			private string generation;

			private string instanceTypeFamilyId;

			public string Generation
			{
				get
				{
					return generation;
				}
				set	
				{
					generation = value;
				}
			}

			public string InstanceTypeFamilyId
			{
				get
				{
					return instanceTypeFamilyId;
				}
				set	
				{
					instanceTypeFamilyId = value;
				}
			}
		}
	}
}
