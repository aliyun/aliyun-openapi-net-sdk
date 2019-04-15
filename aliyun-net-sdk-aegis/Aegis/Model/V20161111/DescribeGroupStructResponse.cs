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
	public class DescribeGroupStructResponse : AcsResponse
	{

		private string requestId;

		private int? groupFather;

		private long? groupId;

		private string groupName;

		private int? groupIndex;

		private int? groupFlag;

		private int? groupLevel;

		private int? machineNum;

		private List<string> groups;

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

		public int? GroupFather
		{
			get
			{
				return groupFather;
			}
			set	
			{
				groupFather = value;
			}
		}

		public long? GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
			}
		}

		public string GroupName
		{
			get
			{
				return groupName;
			}
			set	
			{
				groupName = value;
			}
		}

		public int? GroupIndex
		{
			get
			{
				return groupIndex;
			}
			set	
			{
				groupIndex = value;
			}
		}

		public int? GroupFlag
		{
			get
			{
				return groupFlag;
			}
			set	
			{
				groupFlag = value;
			}
		}

		public int? GroupLevel
		{
			get
			{
				return groupLevel;
			}
			set	
			{
				groupLevel = value;
			}
		}

		public int? MachineNum
		{
			get
			{
				return machineNum;
			}
			set	
			{
				machineNum = value;
			}
		}

		public List<string> Groups
		{
			get
			{
				return groups;
			}
			set	
			{
				groups = value;
			}
		}
	}
}
