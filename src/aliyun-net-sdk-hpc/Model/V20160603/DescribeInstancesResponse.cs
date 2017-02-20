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

namespace Aliyun.Acs.HPC.Model.V20160603
{
	public class DescribeInstancesResponse : AcsResponse
	{
	    public List<Instance> Instances { get; set; }

	    public class Instance{
	        public string InstanceId { get; set; }

	        public InstanceTypeEnum? InstanceType { get; set; }

	        public PackageIdEnum? PackageId { get; set; }

	        public StatusEnum? Status { get; set; }

	        public string InnerIpAddress { get; set; }

	        public JumpserverStatusEnum? JumpserverStatus { get; set; }

	        public string JumpserverInnerIpAddress { get; set; }

	        public string JumpServerPublicIpAddress { get; set; }

	        public enum InstanceTypeEnum {
			
					Prepay,
					Postpay,
			}

			public enum PackageIdEnum {
			
					G4,
					G2,
			}

			public enum StatusEnum {
			
					Stopped,
					Stopping,
					Running,
					Offline,
					Starting,
			}

			public enum JumpserverStatusEnum {
			
					Stopped,
					Stopping,
					Running,
					Starting,
			}
		}
	}
}