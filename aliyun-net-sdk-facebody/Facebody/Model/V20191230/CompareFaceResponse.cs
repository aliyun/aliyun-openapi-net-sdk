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

namespace Aliyun.Acs.facebody.Model.V20191230
{
	public class CompareFaceResponse : AcsResponse
	{

		private string requestId;

		private CompareFace_Data data;

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

		public CompareFace_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class CompareFace_Data
		{

			private float? confidence;

			private List<string> thresholds;

			private List<string> rectAList;

			private List<string> rectBList;

			public float? Confidence
			{
				get
				{
					return confidence;
				}
				set	
				{
					confidence = value;
				}
			}

			public List<string> Thresholds
			{
				get
				{
					return thresholds;
				}
				set	
				{
					thresholds = value;
				}
			}

			public List<string> RectAList
			{
				get
				{
					return rectAList;
				}
				set	
				{
					rectAList = value;
				}
			}

			public List<string> RectBList
			{
				get
				{
					return rectBList;
				}
				set	
				{
					rectBList = value;
				}
			}
		}
	}
}
