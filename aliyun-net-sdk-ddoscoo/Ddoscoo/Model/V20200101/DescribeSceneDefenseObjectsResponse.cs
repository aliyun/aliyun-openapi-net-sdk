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
	public class DescribeSceneDefenseObjectsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeSceneDefenseObjects__Object> objects;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<DescribeSceneDefenseObjects__Object> Objects
		{
			get
			{
				return objects;
			}
			set	
			{
				objects = value;
			}
		}

		public class DescribeSceneDefenseObjects__Object
		{

			private string policyId;

			private string domain;

			private string vip;

			public string PolicyId
			{
				get
				{
					return policyId;
				}
				set	
				{
					policyId = value;
				}
			}

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

			public string Vip
			{
				get
				{
					return vip;
				}
				set	
				{
					vip = value;
				}
			}
		}
	}
}
