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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeClassDetailsResponse : AcsResponse
	{

		private string requestId;

		private string classCode;

		private string maxIOMBPS;

		private string maxConnections;

		private string classGroup;

		private string cpu;

		private string instructionSetArch;

		private string memoryClass;

		private string maxIOPS;

		private string referencePrice;

		private string category;

		private string dBInstanceStorageType;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "ClassCode")]
		public string ClassCode
		{
			get
			{
				return classCode;
			}
			set	
			{
				classCode = value;
			}
		}

		[JsonProperty(PropertyName = "MaxIOMBPS")]
		public string MaxIOMBPS
		{
			get
			{
				return maxIOMBPS;
			}
			set	
			{
				maxIOMBPS = value;
			}
		}

		[JsonProperty(PropertyName = "MaxConnections")]
		public string MaxConnections
		{
			get
			{
				return maxConnections;
			}
			set	
			{
				maxConnections = value;
			}
		}

		[JsonProperty(PropertyName = "ClassGroup")]
		public string ClassGroup
		{
			get
			{
				return classGroup;
			}
			set	
			{
				classGroup = value;
			}
		}

		[JsonProperty(PropertyName = "Cpu")]
		public string Cpu
		{
			get
			{
				return cpu;
			}
			set	
			{
				cpu = value;
			}
		}

		[JsonProperty(PropertyName = "InstructionSetArch")]
		public string InstructionSetArch
		{
			get
			{
				return instructionSetArch;
			}
			set	
			{
				instructionSetArch = value;
			}
		}

		[JsonProperty(PropertyName = "MemoryClass")]
		public string MemoryClass
		{
			get
			{
				return memoryClass;
			}
			set	
			{
				memoryClass = value;
			}
		}

		[JsonProperty(PropertyName = "MaxIOPS")]
		public string MaxIOPS
		{
			get
			{
				return maxIOPS;
			}
			set	
			{
				maxIOPS = value;
			}
		}

		[JsonProperty(PropertyName = "ReferencePrice")]
		public string ReferencePrice
		{
			get
			{
				return referencePrice;
			}
			set	
			{
				referencePrice = value;
			}
		}

		[JsonProperty(PropertyName = "Category")]
		public string Category
		{
			get
			{
				return category;
			}
			set	
			{
				category = value;
			}
		}

		[JsonProperty(PropertyName = "DBInstanceStorageType")]
		public string DBInstanceStorageType
		{
			get
			{
				return dBInstanceStorageType;
			}
			set	
			{
				dBInstanceStorageType = value;
			}
		}
	}
}
