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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class FaceCompareResponse : AcsResponse
	{

		private string requestId;

		private List<FaceCompare_CompareResultItem> compareResult;

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

		public List<FaceCompare_CompareResultItem> CompareResult
		{
			get
			{
				return compareResult;
			}
			set	
			{
				compareResult = value;
			}
		}

		public class FaceCompare_CompareResultItem
		{

			private float? similarity;

			private FaceCompare_FaceA faceA;

			private FaceCompare_FaceB faceB;

			public float? Similarity
			{
				get
				{
					return similarity;
				}
				set	
				{
					similarity = value;
				}
			}

			public FaceCompare_FaceA FaceA
			{
				get
				{
					return faceA;
				}
				set	
				{
					faceA = value;
				}
			}

			public FaceCompare_FaceB FaceB
			{
				get
				{
					return faceB;
				}
				set	
				{
					faceB = value;
				}
			}

			public class FaceCompare_FaceA
			{

				private string imageUrl;

				private List<string> axis;

				public string ImageUrl
				{
					get
					{
						return imageUrl;
					}
					set	
					{
						imageUrl = value;
					}
				}

				public List<string> Axis
				{
					get
					{
						return axis;
					}
					set	
					{
						axis = value;
					}
				}
			}

			public class FaceCompare_FaceB
			{

				private string imageUrl;

				private List<string> axis1;

				public string ImageUrl
				{
					get
					{
						return imageUrl;
					}
					set	
					{
						imageUrl = value;
					}
				}

				public List<string> Axis1
				{
					get
					{
						return axis1;
					}
					set	
					{
						axis1 = value;
					}
				}
			}
		}
	}
}