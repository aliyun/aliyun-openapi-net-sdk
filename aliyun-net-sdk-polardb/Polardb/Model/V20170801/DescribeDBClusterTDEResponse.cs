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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBClusterTDEResponse : AcsResponse
	{

		private string automaticRotation;

		private string dBClusterId;

		private string encryptNewTables;

		private string encryptionKey;

		private string requestId;

		private string rotationInterval;

		private string tDERegion;

		private string tDEStatus;

		public string AutomaticRotation
		{
			get
			{
				return automaticRotation;
			}
			set	
			{
				automaticRotation = value;
			}
		}

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
			}
		}

		public string EncryptNewTables
		{
			get
			{
				return encryptNewTables;
			}
			set	
			{
				encryptNewTables = value;
			}
		}

		public string EncryptionKey
		{
			get
			{
				return encryptionKey;
			}
			set	
			{
				encryptionKey = value;
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

		public string RotationInterval
		{
			get
			{
				return rotationInterval;
			}
			set	
			{
				rotationInterval = value;
			}
		}

		public string TDERegion
		{
			get
			{
				return tDERegion;
			}
			set	
			{
				tDERegion = value;
			}
		}

		public string TDEStatus
		{
			get
			{
				return tDEStatus;
			}
			set	
			{
				tDEStatus = value;
			}
		}
	}
}
