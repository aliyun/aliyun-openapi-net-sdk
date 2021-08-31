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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class ListK8sPvcResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<ListK8sPvc_K8sPvcListItem> k8sPvcList;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public List<ListK8sPvc_K8sPvcListItem> K8sPvcList
		{
			get
			{
				return k8sPvcList;
			}
			set	
			{
				k8sPvcList = value;
			}
		}

		public class ListK8sPvc_K8sPvcListItem
		{

			private string name;

			private string _namespace;

			private string creationTime;

			private string volumeName;

			private string volumeMode;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string _Namespace
			{
				get
				{
					return _namespace;
				}
				set	
				{
					_namespace = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string VolumeName
			{
				get
				{
					return volumeName;
				}
				set	
				{
					volumeName = value;
				}
			}

			public string VolumeMode
			{
				get
				{
					return volumeMode;
				}
				set	
				{
					volumeMode = value;
				}
			}
		}
	}
}
