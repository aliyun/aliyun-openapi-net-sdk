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

namespace Aliyun.Acs.Ecs.Model.V20151101
{
	public class OpsDetailNcResponse : AcsResponse
	{

		private string ncId;

		private string ncIp;

		private string zoneNo;

		private string rackId;

		private int? totalCpu;

		private int? totalDisk;

		private int? totalMem;

		private int? availableCpu;

		private int? availableDisk;

		private int? availableMem;

		public string NcId
		{
			get
			{
				return ncId;
			}
			set	
			{
				ncId = value;
			}
		}

		public string NcIp
		{
			get
			{
				return ncIp;
			}
			set	
			{
				ncIp = value;
			}
		}

		public string ZoneNo
		{
			get
			{
				return zoneNo;
			}
			set	
			{
				zoneNo = value;
			}
		}

		public string RackId
		{
			get
			{
				return rackId;
			}
			set	
			{
				rackId = value;
			}
		}

		public int? TotalCpu
		{
			get
			{
				return totalCpu;
			}
			set	
			{
				totalCpu = value;
			}
		}

		public int? TotalDisk
		{
			get
			{
				return totalDisk;
			}
			set	
			{
				totalDisk = value;
			}
		}

		public int? TotalMem
		{
			get
			{
				return totalMem;
			}
			set	
			{
				totalMem = value;
			}
		}

		public int? AvailableCpu
		{
			get
			{
				return availableCpu;
			}
			set	
			{
				availableCpu = value;
			}
		}

		public int? AvailableDisk
		{
			get
			{
				return availableDisk;
			}
			set	
			{
				availableDisk = value;
			}
		}

		public int? AvailableMem
		{
			get
			{
				return availableMem;
			}
			set	
			{
				availableMem = value;
			}
		}
	}
}