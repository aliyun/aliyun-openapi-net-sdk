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

namespace Aliyun.Acs.imageprocess.Model.V20200320
{
	public class CalcBMDResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private CalcBMD_Data data;

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

		public string Code
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

		public CalcBMD_Data Data
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

		public class CalcBMD_Data
		{

			private string resultURL;

			private List<CalcBMD_DetectionsItem> detections;

			private List<string> spacing;

			private List<string> origin;

			public string ResultURL
			{
				get
				{
					return resultURL;
				}
				set	
				{
					resultURL = value;
				}
			}

			public List<CalcBMD_DetectionsItem> Detections
			{
				get
				{
					return detections;
				}
				set	
				{
					detections = value;
				}
			}

			public List<string> Spacing
			{
				get
				{
					return spacing;
				}
				set	
				{
					spacing = value;
				}
			}

			public List<string> Origin
			{
				get
				{
					return origin;
				}
				set	
				{
					origin = value;
				}
			}

			public class CalcBMD_DetectionsItem
			{

				private string vertId;

				private float? vertBMD;

				private float? vertTScore;

				private float? vertZScore;

				private float? vertCategory;

				public string VertId
				{
					get
					{
						return vertId;
					}
					set	
					{
						vertId = value;
					}
				}

				public float? VertBMD
				{
					get
					{
						return vertBMD;
					}
					set	
					{
						vertBMD = value;
					}
				}

				public float? VertTScore
				{
					get
					{
						return vertTScore;
					}
					set	
					{
						vertTScore = value;
					}
				}

				public float? VertZScore
				{
					get
					{
						return vertZScore;
					}
					set	
					{
						vertZScore = value;
					}
				}

				public float? VertCategory
				{
					get
					{
						return vertCategory;
					}
					set	
					{
						vertCategory = value;
					}
				}
			}
		}
	}
}
