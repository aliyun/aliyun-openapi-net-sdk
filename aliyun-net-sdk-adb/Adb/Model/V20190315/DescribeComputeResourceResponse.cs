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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeComputeResourceResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeComputeResource_ComputeResourceItem> computeResource;

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

		public List<DescribeComputeResource_ComputeResourceItem> ComputeResource
		{
			get
			{
				return computeResource;
			}
			set	
			{
				computeResource = value;
			}
		}

		public class DescribeComputeResource_ComputeResourceItem
		{

			private string displayValue;

			private string realValue;

			public string DisplayValue
			{
				get
				{
					return displayValue;
				}
				set	
				{
					displayValue = value;
				}
			}

			public string RealValue
			{
				get
				{
					return realValue;
				}
				set	
				{
					realValue = value;
				}
			}
		}
	}
}
