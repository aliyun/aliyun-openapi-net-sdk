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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class GetFileDetectResultResponse : AcsResponse
	{

		private string requestId;

		private List<GetFileDetectResult_Result> resultList;

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

		public List<GetFileDetectResult_Result> ResultList
		{
			get
			{
				return resultList;
			}
			set	
			{
				resultList = value;
			}
		}

		public class GetFileDetectResult_Result
		{

			private string hashKey;

			private int? result;

			private int? score;

			private string virusType;

			private string ext;

			public string HashKey
			{
				get
				{
					return hashKey;
				}
				set	
				{
					hashKey = value;
				}
			}

			public int? Result
			{
				get
				{
					return result;
				}
				set	
				{
					result = value;
				}
			}

			public int? Score
			{
				get
				{
					return score;
				}
				set	
				{
					score = value;
				}
			}

			public string VirusType
			{
				get
				{
					return virusType;
				}
				set	
				{
					virusType = value;
				}
			}

			public string Ext
			{
				get
				{
					return ext;
				}
				set	
				{
					ext = value;
				}
			}
		}
	}
}
