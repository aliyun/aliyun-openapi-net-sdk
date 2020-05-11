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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class ListInstalledSoftwareResponse : AcsResponse
	{

		private string requestId;

		private List<ListInstalledSoftware_SoftwareListItem> softwareList;

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

		public List<ListInstalledSoftware_SoftwareListItem> SoftwareList
		{
			get
			{
				return softwareList;
			}
			set	
			{
				softwareList = value;
			}
		}

		public class ListInstalledSoftware_SoftwareListItem
		{

			private string softwareId;

			private string softwareName;

			private string softwareVersion;

			private string softwareStatus;

			public string SoftwareId
			{
				get
				{
					return softwareId;
				}
				set	
				{
					softwareId = value;
				}
			}

			public string SoftwareName
			{
				get
				{
					return softwareName;
				}
				set	
				{
					softwareName = value;
				}
			}

			public string SoftwareVersion
			{
				get
				{
					return softwareVersion;
				}
				set	
				{
					softwareVersion = value;
				}
			}

			public string SoftwareStatus
			{
				get
				{
					return softwareStatus;
				}
				set	
				{
					softwareStatus = value;
				}
			}
		}
	}
}
