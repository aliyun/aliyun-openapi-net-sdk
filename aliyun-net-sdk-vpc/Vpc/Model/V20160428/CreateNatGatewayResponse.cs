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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class CreateNatGatewayResponse : AcsResponse
	{

		private string requestId;

		private string natGatewayId;

		private List<string> forwardTableIds;

		private List<string> snatTableIds;

		private List<string> bandwidthPackageIds;

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

		public string NatGatewayId
		{
			get
			{
				return natGatewayId;
			}
			set	
			{
				natGatewayId = value;
			}
		}

		public List<string> ForwardTableIds
		{
			get
			{
				return forwardTableIds;
			}
			set	
			{
				forwardTableIds = value;
			}
		}

		public List<string> SnatTableIds
		{
			get
			{
				return snatTableIds;
			}
			set	
			{
				snatTableIds = value;
			}
		}

		public List<string> BandwidthPackageIds
		{
			get
			{
				return bandwidthPackageIds;
			}
			set	
			{
				bandwidthPackageIds = value;
			}
		}
	}
}
